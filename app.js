import express from "express";

let app = express();

app.use(express.json());
app.use(express.urlencoded({ extended: false }));
app.use(express.static("public"));
app.get("/", (req, res) => {
  res.sendFile("/home/hassanzhd/Desktop/Portfolio_Website/Home.html");
});

app.listen(5000);
