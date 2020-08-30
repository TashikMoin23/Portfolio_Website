document.querySelectorAll(".box").forEach((item) => {
  item.addEventListener("mouseover", () => {
    item.classList.remove("box");
    item.classList.add("boxe");
  });

  item.addEventListener("mouseout", () => {
    item.classList.remove("boxe");
    item.classList.add("box");
  });
});
