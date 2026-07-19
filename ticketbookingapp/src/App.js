import React, { Component } from "react";
import GuestPage from "./GuestPage";
import UserPage from "./UserPage";

class App extends Component {
  constructor() {
    super();
    this.state = {
      isLoggedIn: false
    };
  }

  handleLogin = () => {
    this.setState({ isLoggedIn: true });
  };

  handleLogout = () => {
    this.setState({ isLoggedIn: false });
  };

  render() {
    return (
      <div style={{ padding: "20px" }}>
        <h1>Ticket Booking App</h1>

        {this.state.isLoggedIn ? (
          <>
            <button onClick={this.handleLogout}>Logout</button>
            <UserPage />
          </>
        ) : (
          <>
            <button onClick={this.handleLogin}>Login</button>
            <GuestPage />
          </>
        )}
      </div>
    );
  }
}

export default App;