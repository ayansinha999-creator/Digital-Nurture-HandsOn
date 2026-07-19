import { BrowserRouter, Routes, Route, Link, Navigate } from "react-router-dom";
import Home from "./Home";
import TrainersList from "./TrainersList";
import TrainersDetails from "./TrainerDetails";

function App() {
  return (
    <BrowserRouter>
      <div>
        <h1>Trainers Application</h1>

        <nav>
          <Link to="/home">Home</Link> |{" "}
          <Link to="/trainers">Trainers</Link>
        </nav>

        <hr />

        <Routes>
          <Route path="/" element={<Navigate to="/home" />} />
          <Route path="/home" element={<Home />} />
          <Route path="/trainers" element={<TrainersList />} />
          <Route path="/trainer/:id" element={<TrainersDetails />} />
        </Routes>
      </div>
    </BrowserRouter>
  );
}

export default App;