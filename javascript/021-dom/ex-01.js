function btnClick() {
  const tb = document.getElementById("textBox");
  tb.value = "Это текст из JS";
}

const btn = document.getElementById("btnAction");

btn.addEventListener("click", btnClick);