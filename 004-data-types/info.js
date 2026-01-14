// Основные типы данных

// Число (Number):
let num = 10;
let floatNum = 3.14;

// String
let str = `Hello World!`;

// Boolean
let isTrue = true;
let isFalse = false;
let check = 1 > 2;

// Undefined - объявлены, но не инициализированы
let undefinedValue;

// Object
let obj = {
    name: "Jane",
    age: 30,
    city: "Smolensk",
    profession: "teacher",
    hobbies: ["reading", "hiking", "cooking"],
    isMarried: false,
};

// Array - тоже объект
let numbers = [1, 2, 3, 4, 5];
let words = [
    "one",
    "two",
    "three",
    "four",
    "five"
];

// function - тоже тип данных
const welcomeUser = function (name) {
    console.log(`Привет ${name}!`);
};

const greetUser = name => {
    console.log(`Привет ${name}!`);
};


// Symbol - уникальное и неизменяемое значение. Символы часто используются в качестве идентификаторов для объектов
const mySymbol = Symbol();

const myObject = {
    [mySymbol]: "Значение символа",
    name: "Jane",
    age: 30,
};

// BigInt
const bigNumber = 521746532874582134981539546135667146312946981612653712783128587647167421638712576312786451383126378n;


