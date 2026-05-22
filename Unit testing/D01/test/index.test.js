import * as chai from 'chai'

const {assert , expect}= chai;

chai.should();
import {capitalizeText ,createArray ,obj1 , obj2 ,CheckPositivity , Mult ,obj3} from '../index.js'

describe(" P 1 --- capitalizeText", () => {

  it("should return a string", () => {
    expect(capitalizeText("str")).a("string");
  })

  it("capitalize the string", () => {
    expect(capitalizeText("str")).equal("STR");
  })

  it("should throw TypeError if input is number", () => {
    expect(() => capitalizeText(12)).throw( "parameter should be string");
  })


});


describe(" p 2 --- createArray",()=>{
    it("should return an array",()=>{
        expect(createArray(3)).an("array");
    })

it("should return an array of length 3 and include 1 ", () => {
    createArray(3).should.be.an("array").with.lengthOf(3).and.to.include(1);
  })

    it("should delay the testing process for 5 seconds", function (done)  {
            this.timeout(6000);

        setTimeout(() => {
            expect(createArray(3)).lengthOf(3);
            done()
        }, 5000);
    })
    it("pending ");
})

describe ("P3 --- equality ",()=>{
it("should verify deep equality using Expect style", () => {
    expect(obj1).to.deep.equal(obj2);
  })

  it("should verify deep equality using Should style", () => {
    obj1.should.deep.equal(obj2);
  })

  it("should verify deep equality using Assert style", () => {
    assert.deepEqual(obj1, obj2);
  })
})


describe("P4--- CheckPositivity", () => {

   it("(positive number)", () => {
    CheckPositivity(4).should.equal(true);
    expect(CheckPositivity(4)).to.equal(true);
    assert.equal(CheckPositivity(4), true);
  })

  it(" (negative number)", () => {
    CheckPositivity(-1).should.equal(false);
    expect(CheckPositivity(-1)).to.equal(false);
    assert.equal(CheckPositivity(-1), false);
  })

  it("(not greater than zero)", () => {
    CheckPositivity(0).should.equal(false);
    expect(CheckPositivity(0)).to.equal(false);
    assert.equal(CheckPositivity(0), false);
  })
})


describe("P5 --- Mult function tests", () => {
  it(" above 0", () => {
    let x = 5;
    assert.isAbove(x, 0);
    assert.isAbove(Mult(x), 0);
  })
})

describe("P6 --- Deep nested object ", () => {
  it(" check nested ", () => {
    assert.deepNestedPropertyVal(obj3, 'a.b[0]', { x: 1 });
  })
})