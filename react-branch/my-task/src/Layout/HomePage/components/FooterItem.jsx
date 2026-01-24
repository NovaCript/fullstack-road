import React from "react";

const currentYear = new Date().getFullYear();
const footer = `© Авторское право дает право на авторское право ${currentYear}`;

const FooterItem = () => {
  return (
    <div>
      <footer style={{ position: "fixed", bottom: 0, width: "100%" }}>
        {footer}
      </footer>
    </div>
  );
};

export default FooterItem;
