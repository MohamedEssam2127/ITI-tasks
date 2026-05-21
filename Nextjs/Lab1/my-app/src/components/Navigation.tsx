import React from "react";
import NavLink from "./NavLink";

const navItems = [
  { name: "Home", path: "/" },
  { name: "products", path: "/products" },
  { name: "category", path: "/category" },
];

export default function Navigation() {
  return (
    <nav className="navbar navbar-expand">
      <ul className="navbar-nav me-auto mb-2 mb-lg-0">
        {navItems.map(({ name, path }) => (
          <li key={name} className="nav-item">
            <NavLink name={name} path={path} />
          </li>
        ))}
      </ul>
    </nav>
  );
}