import { describe, it, expect } from "@jest/globals";
import { add } from "./lab";

describe("add",()=>{

 it("return 0 for empty string",()=>{
  expect(add("")).toBe(0);
 });

  it("number itself when given a single number", () => {
    expect(add("1")).toBe(1);
    expect(add("2")).toBe(2);
  });
})


describe("V2", () => {
   it("sums an unknown number of numbers", () => {
    expect(add("1,2,3")).toBe(6);
    expect(add("4,5,6,7")).toBe(22);
  });
});

describe("V3", () => {
    it("handles new lines between numbers", () => {
        expect(add("1\n2,3")).toBe(6);
    })
})

describe("V4", () => {
    it("throws an exception for negative numbers", () => {
        expect(() => add("1,-2,3")).toThrow("negatives not allowed: -2");
        expect(() => add("-1,-2,3")).toThrow("negatives not allowed: -1, -2");
        });
     } );