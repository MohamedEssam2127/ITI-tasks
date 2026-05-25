//? using mocha and chai
fetch('https://jsonplaceholder.typicode.com/posts')
  .then(response => {
    if (!response.ok) {
      throw new Error('Network response was not ok ' + response.statusText);
    }
    return response.json();
  })
  .then(data => {
    console.log(data); // Handle the data from the API
  })
  .catch(error => {
    console.error('There has been a problem with your fetch operation:', error);
  });

//? using expect test data length and type that returned from this code
//? Task 2 --> implement all the unit testing cases for the following functions using jasmine
MathUtils = function () {};

MathUtils.prototype.sum = function (number1, number2) {
  return number1 + number2;
};

MathUtils.prototype.substract = function (number1, number2) {
  return number1 - number2;
};

MathUtils.prototype.multiply = function (number1, number2) {
  return number1 * number2;
};

MathUtils.prototype.divide = function (number1, number2) {
  return number1 / number2;
};

MathUtils.prototype.average = function (number1, number2) {
  return (number1 + number2) / 2;
};

MathUtils.prototype.factorial = function (number) {
  if (number < 0) {
    throw new Error("There is no factorial for negative numbers");
  } else if (number == 1 || number == 0) {
    return 1;
  } else {
    return number * this.factorial(number - 1);
  }
};

MathUtils.prototype.checkPositivity = function (number) {
  if (number < 0) return false;
  else return true;
};



module.exports = { MathUtils, obj, sayHelloWorld , doSomeThingLater };

//? Task 3 --> test two requests in node with using async/await instead of done()
