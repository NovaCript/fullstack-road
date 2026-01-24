import React, { useState, useEffect } from "react";
import HeaderItem from "./components/HeaderItem";
import ContentItem from "./components/ContentItem";
import FooterItem from "./components/FooterItem";
import axios from "axios";

const baseUrl = `https://jsonplaceholder.typicode.com/posts`;

const HomePage = () => {
  const header = "Какой то заголовок";
  const person = {
    firstName: "Gleb",
    lastName: "Iatsenko",
  };

  const [labels, setLabels] = useState([]);

  // useEffect(() => {
  //   axios.get(baseUrl).then((res) => {
  //     const temp = [];
  //     res.data.slice(0, 5).forEach((item) => {
  //       temp.push({
  //         id: item.id,
  //         cardTitle: item.title.slice(0,10),
  //         cardText: item.body.slice(0, 50),
  //       });
  //       setLabels(temp);
  //     });
  //   });
  // });

  useEffect(() => {
    axios.get(baseUrl).then((res) => {
      setLabels(res.data.slice(0, 5));
    });
  }, []);

  const linkImg = `https://picsum.photos/200/100?random=`;
  return (
    <div className="container col-10">
      <HeaderItem headerText={header} personInfo={person} />
      <ContentItem setOfLabels={labels} linkImg={linkImg} />
      {/* <button className="btn btn-primary"
      onClick={() => {setLabels([...labels,
        { id: 1, cardTitle: "Заголовок 1", cardText: "Описание 1" }
      ])
      }}
      >Добавить элемент</button> */}
      <FooterItem />
    </div>
  );
};

export default HomePage;
