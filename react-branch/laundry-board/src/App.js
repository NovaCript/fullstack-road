import React, { useState, useEffect } from 'react';
import { motion, AnimatePresence } from 'framer-motion';
import './App.css';

const ROPE_POSITIONS = [150, 350, 550];

const LaundryCard = ({ id, content, x, y, onUpdate, onDelete }) => {
  const [isDragging, setIsDragging] = useState(false);

  const handleDragEnd = (event, info) => {
    setIsDragging(false);
    // Ищем ближайшую веревку по Y
    const closestRope = ROPE_POSITIONS.reduce((prev, curr) => 
      Math.abs(curr - info.point.y) < Math.abs(prev - info.point.y) ? curr : prev
    );

    onUpdate(id, { 
      x: info.point.x - 80, 
      y: closestRope,
      content 
    });
  };

  return (
    <motion.div
      drag
      dragMomentum={false}
      onDragStart={() => setIsDragging(true)}
      onDragEnd={handleDragEnd}
      initial={{ x, y, opacity: 0, scale: 0.8 }}
      animate={{ 
        x, 
        y, 
        opacity: 1, 
        scale: 1,
        rotate: isDragging ? 0 : [ -1.5, 1.5, -1.5 ] 
      }}
      exit={{ opacity: 0, scale: 0.5 }}
      transition={{ 
        rotate: { repeat: Infinity, duration: 4, ease: "easeInOut" },
        type: "spring", stiffness: 300, damping: 25
      }}
      className="card"
    >
      <div className="clothespin"></div>
      <button className="delete-btn" onClick={() => onDelete(id)}>×</button>
      
      <div 
        className="card-inner"
        contentEditable
        suppressContentEditableWarning
        onBlur={(e) => onUpdate(id, { x, y, content: e.target.innerText })}
      >
        {content}
      </div>
    </motion.div>
  );
};

export default function App() {
  const [cards, setCards] = useState(() => {
    const saved = localStorage.getItem('laundry-cards');
    return saved ? JSON.parse(saved) : [{ id: 1, x: 100, y: 150, content: 'Напиши здесь что-нибудь...' }];
  });

  useEffect(() => {
    localStorage.setItem('laundry-cards', JSON.stringify(cards));
  }, [cards]);

  const addCard = (yPos) => {
    const newCard = {
      id: Date.now(),
      x: Math.random() * (window.innerWidth - 250) + 50,
      y: yPos,
      content: 'Новая заметка'
    };
    setCards([...cards, newCard]);
  };

  const updateCard = (id, payload) => {
    setCards(cards.map(c => c.id === id ? { ...c, ...payload } : c));
  };

  const deleteCard = (id) => {
    setCards(cards.filter(c => c.id !== id));
  };

  return (
    <div className="laundry-room">
      {ROPE_POSITIONS.map((yPos, i) => (
        <div key={i} className="rope" style={{ top: yPos }} onClick={() => addCard(yPos)}>
          <span className="hint">Кликни, чтобы повесить белье</span>
        </div>
      ))}

      <AnimatePresence>
        {cards.map(card => (
          <LaundryCard 
            key={card.id} 
            {...card} 
            onUpdate={updateCard} 
            onDelete={deleteCard}
          />
        ))}
      </AnimatePresence>

      <div className="status-bar">
        📌 Твоя доска готова. Карточки качаются и сохраняются!
      </div>
    </div>
  );
}