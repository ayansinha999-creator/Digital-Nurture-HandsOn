import React, { useState } from "react";

function Register() {
  const [name, setName] = useState("");
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");

  const [nameError, setNameError] = useState("");
  const [emailError, setEmailError] = useState("");
  const [passwordError, setPasswordError] = useState("");

  const handleSubmit = (e) => {
    e.preventDefault();

    let valid = true;

    setNameError("");
    setEmailError("");
    setPasswordError("");

    if (name.length < 5) {
      setNameError("Name should have at least 5 characters");
      valid = false;
    }

    if (!email.includes("@") || !email.includes(".")) {
      setEmailError("Enter a valid email");
      valid = false;
    }

    if (password.length < 8) {
      setPasswordError("Password should have at least 8 characters");
      valid = false;
    }

    if (valid) {
      alert("Registration Successful");
    }
  };

  return (
    <div style={{ margin: "30px" }}>
      <h2>Mail Registration</h2>

      <form onSubmit={handleSubmit}>
        <div>
          <label>Name: </label>
          <input
            type="text"
            value={name}
            onChange={(e) => setName(e.target.value)}
          />
          <br />
          <span style={{ color: "red" }}>{nameError}</span>
        </div>

        <br />

        <div>
          <label>Email: </label>
          <input
            type="text"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
          />
          <br />
          <span style={{ color: "red" }}>{emailError}</span>
        </div>

        <br />

        <div>
          <label>Password: </label>
          <input
            type="password"
            value={password}
            onChange={(e) => setPassword(e.target.value)}
          />
          <br />
          <span style={{ color: "red" }}>{passwordError}</span>
        </div>

        <br />

        <button type="submit">Register</button>
      </form>
    </div>
  );
}

export default Register;