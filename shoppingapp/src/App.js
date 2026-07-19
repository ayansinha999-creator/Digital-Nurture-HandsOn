import React, { Component } from "react";
import Cart from "./Cart";

class App extends Component {

    render() {

        const items = [
            { itemname: "Laptop", price: 55000 },
            { itemname: "Mobile", price: 20000 },
            { itemname: "Headphones", price: 3000 },
            { itemname: "Keyboard", price: 1500 },
            { itemname: "Mouse", price: 800 }
        ];

        return (
            <div align="center">
                <h2>Shopping Cart</h2>
                <Cart items={items} />
            </div>
        );
    }
}

export default App;