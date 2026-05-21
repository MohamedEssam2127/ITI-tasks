import React from 'react'
import NavLink from './NavLink'

export default function SideNavigation() {
  return (
    <nav className="d-flex flex-column gap-2 p-3 bg-light rounded shadow-sm h-100" style={{ width: '16rem' }}>
      <h5 className="mb-4 fw-bold">Categories</h5>
      <NavLink name="All Products" path="/category/all" />
      <NavLink name="Electronics" path="/category/electronics" />
    </nav>
  )
}
