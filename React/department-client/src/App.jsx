import { BrowserRouter, Routes, Route, Link } from "react-router-dom";
import AddDepartment from "./pages/AddDepartment";
import AllDepartments from "./pages/AllDepartments";

function App() {
  return (
    <BrowserRouter>
      <nav style={{ padding: "10px", background: "#eee", display: "flex", gap: "15px" }}>
        <Link to="/">All Departments</Link>
        <Link to="/add">Add Department</Link>
      </nav>
      <div style={{ padding: "20px" }}>
        <Routes>
          <Route path="/" element={<AllDepartments />} />
          <Route path="/add" element={<AddDepartment />} />
        </Routes>
      </div>
    </BrowserRouter>
  );
}

export default App;
