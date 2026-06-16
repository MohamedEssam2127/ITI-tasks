import React from "react";
import { render, fireEvent } from "@testing-library/react";
import TestEvents from "./TestEvents";

it("increments counter", function () {
  //? render --> run component [as in browser]
  const { getByTestId } = render(<TestEvents />);

  fireEvent.click(getByTestId("button-up"));

  expect(getByTestId("counter")).toHaveTextContent(1);
});
