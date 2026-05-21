import React from "react";
import Navigation from "./Navigation";


export default function Header() {
  return (
    <header className="navbar navbar-expand-lg navbar-light bg-light border-bottom">
      <div className="container">
        <Navigation />
      </div>
    </header>
  );
}