function tipCalculator(person, total, tip) {
  const p = Number(person);
  const t = Number(total);
  const percent = Number(tip);

  if (
    isNaN(p)
    || isNaN(t)
    || isNaN(percent)
    || p <= 0
    || percent < 0
    || t < 0  
      ) {
    return errorTypeTipCalculator(person, total, tip);
  }

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

function errorTypeTipCalculator(person, total, tip) {
  console.log(`
        Ошибка типов.
            Ожидается получение положительных числовых значений, полуено:
            Колличество человек: ${person}, (тип: ${typeof person})
            Общая сумма счета: ${total}, (тип: ${typeof total})
            Процент чаевых: ${tip}, (тип: ${typeof tip})`);
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
    console.log(`--5-----------------------------------------------------------------------`);
    tipCalculator(`iyrtyr`, -10, `asda`); // error
}


testCaseTip();