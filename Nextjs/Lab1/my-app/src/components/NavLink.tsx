"use client";

import Link from "next/link";
import { usePathname } from "next/navigation";
import React from "react";

interface Props {
  name: string;
  path: string;
}

export default function NavLink({ name, path }: Props) {
  const pathname = usePathname();
  return (
    <Link
      href={path}
      className={`nav-link ${pathname === path ? "active fw-bold" : ""}`}
    >
      {name}
    </Link>
  );
}