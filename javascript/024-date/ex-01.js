// Текущее время
let now = Date();
console.log(now);

// Создание объекта из строки в формате ISO 8601
let dateStr = new Date("2064-07-10")
console.log(dateStr);

// Создание объекта Date из компонентов даты и времени
// Месяц считается с 0!
let dateComponent = new Date(2024, 2, 10, 14, 30, 0);
console.log(dateComponent);

// Создание объекта Date из миллисекунд с начала эпохи Unix
let dateFromMs = new Date(0);
console.log(dateFromMs);

