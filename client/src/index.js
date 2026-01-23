import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";

// const h1Element = document.createElement("h1");
// h1Element.innerText = "Hello World!";
// const root = document.getElementById("root");
// root.appendChild(h1Element);

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(
  <div>
    <h1>Какой то список:</h1>
    <ul>
      <li>Lorem ipsum dolor sit amet.</li>
      <li>Lorem ipsum dolor sit, amet consectetur adipisicing.</li>
      <li>Lorem, ipsum dolor.</li>
    </ul>
  </div>,
);
