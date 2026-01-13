function tipCalculator(person, total, tip) {
  let totalSum = total + (total * tip / 100);
  let costForPerson = (totalSum / person).toFixed(2);
  console.log(`
    -----------------------------------------
        Счет на сумму ${totalSum} руб
        Чаевые: ${tip}%
        С каждого человека по ${costForPerson} руб
    -----------------------------------------    
        `);
}

tipCalculator(4, 1000, 10);
tipCalculator(8, 888, 5);
tipCalculator(2, 2000, 10);
