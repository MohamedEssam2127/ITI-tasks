import React from "react";
import { render } from "@testing-library/react";
import Link from "./Link";

it("h1 textContent should equal to 0", function () {
  const { getByTestId } = render(<Link />);

  expect(getByTestId("counter")).toHaveTextContent(0);
});

it("button should be disabled", function () {
  const { getByTestId } = render(<Link />);

  expect(getByTestId("button-down")).toBeDisabled();
});
