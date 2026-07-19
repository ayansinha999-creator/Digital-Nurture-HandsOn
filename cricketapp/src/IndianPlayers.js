import React from "react";

function IndianPlayers() {

  const players = [
    "Virat", "Rohit", "Gill", "Rahul", "Pant",
    "Hardik", "Jadeja", "Ashwin", "Shami", "Bumrah", "Siraj"
  ];

  const oddPlayers = players.filter((_, index) => index % 2 === 0);
  const evenPlayers = players.filter((_, index) => index % 2 !== 0);

  const T20players = ["Virat", "Rohit", "Surya"];
  const RanjiPlayers = ["Pujara", "Rahane", "Iyer"];

  const mergedPlayers = [...T20players, ...RanjiPlayers];

  return (
    <div>
      <h2>Odd Team Players</h2>
      <ul>
        {oddPlayers.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>

      <h2>Even Team Players</h2>
      <ul>
        {evenPlayers.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>

      <h2>Merged Players</h2>
      <ul>
        {mergedPlayers.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>
    </div>
  );
}

export default IndianPlayers;