import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";


function getTaskRender (array) {
  return (
    <ul>
      {array.map((element) => (
        <li>{element}</li>
      ))}
    </ul>
  );
}

const person = {
  firstName: "Gleb",
  lastName: "Iatsenko",
};

const header = "Какой то заголовок";
const task = ["Умыться", "Выпить кофе", "Посидеть у моря", "Обучение", "Поужинать",];
const currentYear = new Date().getFullYear();
const footer = `© Авторское право дает право на авторское право ${currentYear}`;
const taskList = getTaskRender(task);

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(
  <div>
    <h1>{header}</h1>
    <h2>
      {person.firstName} {person.lastName}
    </h2>
    {taskList}
    <footer style={{ position: "fixed", bottom: 0, width: "100%" }}>
      {footer}
    </footer>
  </div>,
);
