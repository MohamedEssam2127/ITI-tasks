import SideNavigation from "@/components/SideNavigation";
import React from "react";

export default function layout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <div className="container py-5">
      <div className="d-flex gap-5">
        <SideNavigation />
        <div className="flex-grow-1 py-1">
          {children}
        </div>
      </div>
    </div>
  );
}
