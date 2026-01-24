import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";

function getTaskRender(array) {
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
const tasks = [
  "Умыться",
  "Выпить кофе",
  "Посидеть у моря",
  "Обучение",
  "Поужинать",
];
const currentYear = new Date().getFullYear();
const footer = `© Авторское право дает право на авторское право ${currentYear}`;
const taskList = getTaskRender(tasks);

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(
  <div className="container col-10">
    <h1>{header}</h1>
    <h2>
      {person.firstName} {person.lastName}
    </h2>
    {taskList}
    {
      // tasks.map(task => (<li>{task}</li>))
      Array.from({ length: 5 }, (_, index) => (
        <div className="card my-5">
          <img
            src={`https://picsum.photos/200/100?random=${index}`}
            class="card-img-top"
            alt="..."
          />
          <div className="card-body">
            <h5 className="card-title">Card title</h5>
            <p className="card-text">
              Some quick example text to build on the card title and make up the
              bulk of the card’s content.
            </p>
          </div>
        </div>
      ))
    }
    <footer style={{ position: "fixed", bottom: 0, width: "100%" }}>
      {footer}
    </footer>
  </div>,
);
