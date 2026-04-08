// // 1- Create an interface User with properties name (string) and age (number). and it is required not optional 
// //    required create an object with only the name property.

// interface IUser {
//     name:string,
//     age:number
// }
// let u1 :Pick<IUser,"name"> = {
//     name:"essam",
// }
// console.log(u1)
// // 2- Create an interface Profile with optional properties username (string) and email (string).
// //    required create an object with both properties.

// interface Profile {
//     username? :string,
//     email?:string
// }
// let p1 :Required<Profile> ={
//     username:"essam",
//     email:"mo@gmail.com"
// }

// console.log(p1);

// // 3- Use Record to create an object where keys are "red", "green", and "blue", 
// // and values are their corresponding hex color codes (strings). 
// //    Test by accessing the red key.

// type colorNames = "red" | "green" | "blue";

// const hexColors: Record<colorNames, string> = {
//     red: "#FF0000",
//     green: "#00FF00",
//     blue: "#0000FF"
// };

// console.log(hexColors.green);

// // 4- Create an interface Person with properties name (string), age (number), and email (string).
// //    create a new type with only the name and email properties.
// //    Test by creating an object with these properties.

// interface Person {
//    name:string ,
//    age:number,
//    email:string
// }

// type NewPerson = Pick<Person, "name" | "email">;

// const p2: NewPerson = {
//     name: "moEssam",
//     email: "essam"
// };

// console.log(p2);

// // 5- Use the same Person interface from the previous question.
// //    create a new type without the age property.
// //    Test by creating an object with only name and email.

// type NewPerson2 = Omit<Person, "age">;

// const q5: NewPerson2 = {
//     name: "ahmed",
//     email: "essam@gmail.com"
// };

// console.log(q5);


// // 6- Create a union type Colors = "red" | "green" | "blue" | "yellow".
// //   create a new type without "yellow".
// //   Test by assigning a value of the new type.

//  type Colors = "red" | "green" | "blue" | "yellow" ;
// type WithoutYellow = Exclude<Colors, "yellow">;
// let myColor1: WithoutYellow = "red"
// console.log(myColor1);

// // 7- Use the same Colors union type from the previous question.
// //    create a new type with only "red" and "blue".
// //    Test by assigning a value of the new type.


// type colors2 = Extract<Colors, "red" | "blue">;

// let myColor: colors2 = "blue";

// console.log(myColor);
// // 8- Create a union type MaybeString = string | null | undefined.
// //    create a new type without null or undefined.
// //    Test by assigning a value of the new type.

// type MaybeString = string | null | undefined;
// type realString = NonNullable<MaybeString>;
// let t: realString = " Essam";

// console.log(t);

/////////////// 

interface Parent {
    name:string
}

interface Child1 extends Parent {
    age: number;
}

interface Child2 extends Parent {
    address: string;
}
interface Child3  {
    address: string;
}

function printName(person: Parent) {
    console.log(person);
}

const c1: Child1 = { name: "essam", age: 10 };
const c2: Child2 = { name: "essam", address: "123 Main St" };

printName(c1);
printName(c2);
printName(c3);