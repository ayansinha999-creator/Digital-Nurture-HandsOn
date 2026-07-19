import React, { Component } from "react";

class CountPeople extends Component {
  constructor(props) {
    super(props);

    this.state = {
      entrycount: 0,
      exitcount: 0
    };
  }

  UpdateEntry = () => {
    this.setState({
      entrycount: this.state.entrycount + 1
    });
  };

  UpdateExit = () => {
    this.setState({
      exitcount: this.state.exitcount + 1
    });
  };

  render() {
    return (
      <div style={{ textAlign: "center" }}>
        <h2>Mall Entry Counter</h2>

        <h3>People Entered : {this.state.entrycount}</h3>
        <button onClick={this.UpdateEntry}>Login</button>

        <br /><br />

        <h3>People Exited : {this.state.exitcount}</h3>
        <button onClick={this.UpdateExit}>Exit</button>
      </div>
    );
  }
}

export default CountPeople;