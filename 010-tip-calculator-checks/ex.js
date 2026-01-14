function tipCalculator(person, total, tip) {
  if (isNaN(person) || isNaN(total) || isNaN(tip)) {
    return errorTypeTipCalculator(person, total, tip);
  }
  let totalSum = total + (total * tip) / 100;
  let costForPerson = (totalSum / person).toFixed(2);
  console.log(`
    -----------------------------------------
        Счет на сумму ${totalSum} руб
        Чаевые: ${tip}%
        С каждого человека по ${costForPerson} руб
    -----------------------------------------    
        `);
}

function errorTypeTipCalculator(person, total, tip) {
  console.log(`
        Ошибка типов.
            Ожидается получение числовых значений, полуено:
            Колличество человек: ${person}
            Общая сумма счета: ${total}
            Процент чаевых: ${tip}`);
}

function testCaseTip() {
    console.log(`
    Test Case
    `);
    console.log(`--1-----------------------------------------------------------------------`);
    tipCalculator("rwerwerwer", "77", 10); // error
    console.log(`--2-----------------------------------------------------------------------`);
    tipCalculator("11", "22", "10"); // +
    console.log(`--3-----------------------------------------------------------------------`);
    tipCalculator(4, 1000, 10); // +
    console.log(`--4-----------------------------------------------------------------------`);
    tipCalculator(`iyrtyr`, `trtyuu`, `asda`); // error
}


testCaseTip();