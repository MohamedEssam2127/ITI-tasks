/*
Create a StringCalculator with the following requirements:

1) method Add(string numbers) that returns an integer.
	Start with the simplest test case of an empty string, then 1 number, then 2.
	An empty string should return a sum of 0.
	String of numbers can include 0, 1, or 2 integers (e.g. "", "1", "1,2").
	Add returns the sum of the integers provided in the string numbers.
	Remember to refactor after each test.

2) Allow the Add method to handle an unknown number of numbers (in the string).

3) Allow the Add method to handle new lines between numbers (instead of commas).
	The following input is ok: “1\n2,3” (will equal 6)

4) Calling Add with a negative number will throw an exception “negatives not allowed” - and the negative that was passed. 
	If there are multiple negatives, show all of them in the exception message.
*/


//----------------------v1
// export function add(numbers: string): number {
//   if (numbers === "") {
//     return 0;
//   }
//   return parseInt(numbers, 10);
// }

//----------------------v2
// export function add(numbers: string): number { 
// 	if (numbers === "") {
//     return 0;
//   }
//   const parsedNumbers = numbers.split(",");
//   let sum = 0;
//   for (const num of parsedNumbers) {
//     sum += parseInt(num, 10);
//   }
//   return sum;
// }


//----------------------v3

// export function add(numbers: string): number { 
// 	if (numbers === "") {
//     return 0;
//   }
//   const parsedNumbers = numbers.split(/[,\n]/);
//   let sum = 0;
//   for (const num of parsedNumbers) {
//     sum += parseInt(num, 10);
//   }
//   return sum;
// }



//----------------------v4
export function add(numbers: string): number { 
  if (numbers === "") {
    return 0;
  }
  const parsedNumbers = numbers.split(/[,\n]/);
  let sum = 0;
  const neg: string[] = [];

  for (const num of parsedNumbers) {
    const parsedNum = parseInt(num, 10);
    
    if (parsedNum < 0) {
      neg.push(num);
    }
    
    sum += parsedNum;
  }
  if (neg.length > 0) {
    throw new Error(`negatives not allowed: ${neg.join(", ")}`);
  }
  return sum;
}