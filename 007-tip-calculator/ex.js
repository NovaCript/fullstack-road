function tipCalculator(person, total, tip) {
  console.log(`
    -----------------------------------------
        Счет на сумму ${total * 1.1}
        Чаевые: ${tip}%
        С каждого человека по ${(total * 1.1) / person}
    -----------------------------------------    
        `);
}

tipCalculator(4, 1000, 10);
