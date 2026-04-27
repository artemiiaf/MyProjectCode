import { createRequire } from "module";
const require = createRequire(import.meta.url);

const data = require("./data.json");

export const dataApiPattern = (app) => {
  //* get-запрос data
  app.get("/api/data/", (req, res) => {
    return res.json(data.stady);
  });

  app.get("/api/data/:id", (req, res) => {
    const idDataReq = req.params.id;
    console.log("start request id: " + idDataReq);

    for (let i = 0; i < data.stady.length; i++) {
      console.log(`${data.stady[i]}`);
      
    }
  });
};
