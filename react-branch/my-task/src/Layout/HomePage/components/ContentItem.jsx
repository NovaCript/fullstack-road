import React from "react";

// function getTaskRender(array) {
//   return (
//     <ul>
//       {array.map((element) => (
//         <li>{element}</li>
//       ))}
//     </ul>
//   );
// }

// const tasks = [
//   "Умыться",
//   "Выпить кофе",
//   "Посидеть у моря",
//   "Обучение",
//   "Поужинать",
// ];

// const taskList = getTaskRender(tasks);

const ContentItem = (props) => {
  return (
    <div>
      {/* {taskList} */}
      {
        // tasks.map(task => (<li>{task}</li>))
        props.setOfLabels.map((item, index) => (
          <div key={item.id} className="card my-5">
            <img
              src={`${props.linkImg}${index + 1}`}
              className="card-img-top"
              alt={`card-image-${index + 1}`}
            />
            <div className="card-body">
              <h5 className="card-title">{item.title.slice(0, 10)}</h5>
              <p className="card-text">{item.body.slice(0, 50)}</p>
            </div>
          </div>
        ))
      }
    </div>
  );
};

export default ContentItem;
