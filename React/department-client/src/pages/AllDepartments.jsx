import { useState, useEffect } from "react";
import axios from "axios";

function AllDepartments() {
  const [departments, setDepartments] = useState([]);

  useEffect(() => {
    const fetchDepartments = async () => {
      try {
        const response = await axios.get("http://localhost:5142/api/Department");
        const data = response.data?.data ?? response.data ?? [];
        setDepartments(Array.isArray(data) ? data : []);
      } catch (err) {
        console.error(err);
      }
    };

    fetchDepartments();
  }, []);

  return (
    <div>
      <h2>All Departments</h2>
      {departments.length === 0 ? (
        <p>No departments found.</p>
      ) : (
        <table border="1" cellPadding="8">
          <thead>
            <tr>
              <th>Name</th>
              <th>Location</th>
              <th>Students</th>
              <th>Count</th>
              <th>Status</th>
            </tr>
          </thead>
          <tbody>
            {departments.map((d, i) => (
              <tr key={i}>
                <td>{d.name}</td>
                <td>{d.location}</td>
                <td>{d.studentNames?.join(", ")}</td>
                <td>{d.count}</td>
                <td>{d.message}</td>
              </tr>
            ))}
          </tbody>
        </table>
      )}
    </div>
  );
}

export default AllDepartments;
