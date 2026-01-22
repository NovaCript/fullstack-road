// Преобразование к строке
let numToString = 10;
let toStr = String(numToString);

// Преобразование к числу
let strToNum = "10";
console.log(Number(strToNum));

// Преобразование к логическому типу
let strToBool = "Hello";
console.log(Boolean(strToBool));

// Неявное преобразование
let implicitConversion = 10 + "20";
console.log(implicitConversion); // 1020

// Неявное преобразование при сравнении
let num = 10;
let str = "10";
console.log(num == str); // true
console.log(num === str); // false


// Примеры ошибок и путаницы при преобразовании типов

// Непонимание различий между типами данных
let confusionExample = num + str;
console.log(confusionExample); // "1020"

// Неявное преобразование типов
let implicitExample = num.toString() + str;
console.log(implicitExample);

// Неправильное использование операторов сравнения
if (num == str) {
    console.log("Значения равны"); // Это сообщение будет
}


