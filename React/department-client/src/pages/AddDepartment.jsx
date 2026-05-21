import { useState } from "react";
import axios from "axios";

function AddDepartment() {
  const [form, setForm] = useState({
    name: "",
    location: "",
    phoneNumber: "",
    manager: "",
  });

  const handleChange = (e) => {
    setForm({ ...form, [e.target.name]: e.target.value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

    try {
      const response = await axios.post("http://localhost:5142/api/Department", form, {
        headers: { "Content-Type": "application/json" },
      });

      alert("Department added!");
      console.log(response.data);
      setForm({ name: "", location: "", phoneNumber: "", manager: "" });
    } catch (err) {
      console.error(err);
      alert("Failed to add department. See console for details.");
    }
  };

  return (
    <div>
      <h2>Add Department</h2>
      <form onSubmit={handleSubmit} style={{ display: "flex", flexDirection: "column", gap: "10px", maxWidth: "300px" }}>
        <input name="name" placeholder="Name" value={form.name} onChange={handleChange} />
        <input name="location" placeholder="Location" value={form.location} onChange={handleChange} />
        <input name="phoneNumber" placeholder="Phone Number" value={form.phoneNumber} onChange={handleChange} />
        <input name="manager" placeholder="Manager" value={form.manager} onChange={handleChange} />
        <button type="submit">Add</button>
      </form>
    </div>
  );
}

export default AddDepartment;
