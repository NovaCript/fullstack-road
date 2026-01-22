const billAmount = document.getElementById("billAmount");
const tipPercentage = document.getElementById("tipPercentage");
const numberOfPeople = document.getElementById("numberOfPeople");
const btnCalculate = document.getElementById("btnCalculate");

const totalAmountSpan = document.getElementById("totalAmount");
const tipAmountSpan = document.getElementById("tipAmount");
const amountPerPersonSpan = document.getElementById("amountPerPerson");

const inputError = document.getElementById("inputError");

const errorTypeInput = `
Заполните все данные в ячейках
`
const inputAccepted = `
Готово
`

function billCalculator(billAmount, tipPercentage, numberOfPeople) {
  const bill = billAmount.valueAsNumber;
  const tipPercent = tipPercentage.valueAsNumber;
  const people = numberOfPeople.valueAsNumber;

  if (checkerType(bill, tipPercent, people)) {
    return inputError.textContent = errorTypeInput;
  }
  const tip = tipCalculate(bill, tipPercent);
  const total = totalSum(bill, tip);
  const perPerson = costForPerson(total, people);

  inputError.textContent = inputAccepted;
  tipAmountSpan.textContent = tip.toFixed(2);
  totalAmountSpan.textContent = total.toFixed(2);
  amountPerPersonSpan.textContent = perPerson;
}

function checkerType(billAmount, tipPercentage, numberOfPeople) {
  return (
    isNaN(billAmount) ||
    isNaN(tipPercentage) ||
    isNaN(numberOfPeople) ||
    numberOfPeople <= 0 ||
    tipPercentage < 0 ||
    billAmount < 0
  );
}

function tipCalculate(bill, percent) {
  return (bill * percent) / 100;
}

function totalSum(bill, tip) {
  return bill + tip;
}

function costForPerson(total, people) {
  return total / people;
}

btnCalculate.addEventListener("click", () => {
    billCalculator(billAmount, tipPercentage, numberOfPeople);
});
