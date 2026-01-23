import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";

// const h1Element = document.createElement("h1");
// h1Element.innerText = "Hello World!";
// const root = document.getElementById("root");
// root.appendChild(h1Element);

const value = "Какое то значение";
const items = ["Элемент 1", "Элемент 2", "Элемент 3",]

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(
  <div>
    <h1>{value}</h1>
    <ul>
      <li>{items[0]}</li>
      <li>{items[1]}</li>
      <li>{items[2]}</li>
    </ul>
  </div>,
);
