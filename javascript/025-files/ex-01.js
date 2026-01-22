const fs = require("fs");
const data = "Some text sssssssss";

fs.writeFile("example.txt", data, "utf-8", (err) => {
  if (err) {
    console.log("Error write file: ", err);
    return;
  }
  console.log("Success write file.");

  fs.readFile("example.txt", "utf-8", (err, data) => {
    if (err) {
      console.log("Error read file: ", err);
      return;
    }
    console.log("File data: ", data);
    let count = 0;
    for (let i = 0; i < data.length; i++) {
      if (data[i].toLowerCase() === "s") {
        count++;
      }
    }
    console.log("count ", count);
  });
});
