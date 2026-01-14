function tipCalculator(person, total, tip) {
  const p = Number(person);
  const t = Number(total);
  const percent = Number(tip);

  let totalSum = (t + (t * percent) / 100).toFixed(2);
  let costForPerson = (totalSum / p).toFixed(2);
  console.log(`
    -----------------------------------------
        Счет на сумму ${totalSum} руб
        Чаевые: ${percent}%
        С каждого человека по ${costForPerson} руб
    -----------------------------------------    
        `);
}

tipCalculator(4, 1000, 10);
tipCalculator(8, 888, 5);
tipCalculator(2, 2000, 10);
