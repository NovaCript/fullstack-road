import React from "react";

const HeaderItem = (props) => {
  return (
    <div>
      <h1>{props.headerText}</h1>
      <h2>
        {props.personInfo.firstName} {props.personInfo.lastName}
      </h2>
    </div>
  );
};

export default HeaderItem;
