import React from "react";
import officeImg from "./office.jpg";

function App() {

  const office = {
    name: "Tech Park Office",
    rent: 55000,
    address: "Bangalore"
  };

  const offices = [
    { name: "Tech Park", rent: 55000, address: "Bangalore" },
    { name: "Cyber Hub", rent: 75000, address: "Hyderabad" },
    { name: "Business Center", rent: 45000, address: "Pune" }
  ];

  return (
    <div style={{ padding: "20px" }}>
      <h1>Office Space Rental App</h1>

      <img
        src={officeImg}
        alt="Office"
        width="400"
        height="250"
      />

      <h2>Office Details</h2>

      <p><b>Name:</b> {office.name}</p>

      <p>
        <b>Rent:</b>
        <span
          style={{
            color: office.rent < 60000 ? "red" : "green"
          }}
        >
          {" "}₹{office.rent}
        </span>
      </p>

      <p><b>Address:</b> {office.address}</p>

      <hr />

      <h2>Available Office Spaces</h2>

      {offices.map((item, index) => (
        <div key={index}>
          <p><b>Name:</b> {item.name}</p>

          <p>
            <b>Rent:</b>
            <span
              style={{
                color: item.rent < 60000 ? "red" : "green"
              }}
            >
              {" "}₹{item.rent}
            </span>
          </p>

          <p><b>Address:</b> {item.address}</p>

          <hr />
        </div>
      ))}
    </div>
  );
}

export default App;