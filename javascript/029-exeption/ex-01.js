// try {
// console.log(nonExistentVariable);
// if !(some) {
//  throw new Error("Условие не выполнено");
// }
// } catch (error) {
// console.log(`Произошла ошибка: ${error.message}`);

// }
// finally {
// console.log("finally");
// }

const obj = {
  foo: "foo",
  bar: "bar",
};

try {
  console.log(obj.foo());
} catch (error) {
  console.log("Что то пошло не так");
} finally {
  console.log("finally");
}
