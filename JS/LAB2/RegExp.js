function numOfletters () {
    let count =0 ;
    let x = prompt('enter string ')
    let y = prompt('enter char ');
    if( y.length > 1){
        alert('must enter one char ')
        return

    }
    let z = prompt("consider case sensitivity ? (yes/no)").toLowerCase();
    if (z==='no'){
       x = x.toLocaleLowerCase()
       y = y.toLocaleLowerCase()
    }
    for(let i =0 ;i< x.length ;i++){
        if(x.charAt(i)==y){
            count++;
        }
    }
    console.log("char appear  "+ count + " times")
}

//2 
function palindrome (){
    let str = prompt("enter string to check "); //raDaR
     let z = prompt("consider case sensitivity ? (yes/no)").toLowerCase();
    if (z==='no'){
        str = str.toLocaleLowerCase()
    } 
    let i = 0;
    let j = str.length-1
    for(;i!=j; i++ ,j--){
        if(str.charAt(i) !== str.charAt(j)){
            console.log("not palindrome")  
            return ;
        }
    }
    console.log(" the stirng is palindrome ")
}

//3 
function largestString(){
    let x  = prompt("enter your string ");
    let strArray = x.split(" ")
    let indexOfFirst = 0;
    let maxSize =0 ;
    for(let  i = 0 ;i < strArray.length ;i++){
        if (strArray.at(i).length > maxSize){
            maxSize = strArray.at(i).length 
            indexOfFirst = i ;
        }
    }
    console.log ('the largerst string is '+ strArray.at(indexOfFirst) + " and length is "+ maxSize)
}


//4 
function userInfo () {
    let userName = prompt("enter your name");
    const nameReg = /^[a-zA-Z\s]+$/; 
    let nameFlag = false
    while (!nameFlag){
  if ( nameReg.test(userName.trim())) {
    console.log("Valid name");
    nameFlag = true 
} else {
    alert("Invalid name  Please use English letters and spaces only.");
    userName=  prompt("enter your name")
}
    }

      let phone = prompt("enter your phone ");
    const phoneReg = /^[0-9]{8}$/; 
    let phoneFlag = false
    while (!phoneFlag){
  if (phoneReg.test(phone.trim())) {
    console.log("Valid phone ");
    phoneFlag = true 
} else {
    alert("Invalid phone Please  enter 8 numbers   only ");
    phone=  prompt("enter your phone")
}
    }

        let mobile = prompt("enter your mobile ");
    const mobileReg = /^(010|011|012)[0-9]{8}$/; 
    let mobileFlag = false
    while (!mobileFlag){
  if (mobileReg.test(mobile.trim())) {
    console.log("Valid mobile ");
    mobileFlag = true 
} else {
    alert("Invalid mobile Please  enter 11 numbers   only start with 010 011 012 ");
    mobile=  prompt("enter your mobile")
}
    }
    let email = prompt("Enter your email (e.g., abc@123.com):");
    const emailReg = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$/; 
    while (!emailReg.test(email?.trim())) {
        alert("Invalid email Please follow the format: abc@123.com");
    
        email = prompt("Enter your email:");
    }

    let color = prompt("Choose a color ").toLocaleLowerCase();
     const colorReg = /^(red|green|blue)$/i;
    while (!colorReg.test(color?.trim())) {
        alert("Please choose either {red green blue}");
         color = prompt("Choose a color (red, green, or blue):");
    }
    console.log ("%cyour name   is "+ userName +'\n' + " phone : "+ phone +'\n'+ " mobile : "+ mobile  +'\n'+ 'email : ' + email +'\n'  ,'color: ' +color+'; font-weight: bold;' )
  
}


// 2 math 
// 1
function  circleArea () {
    let radius = prompt("Enter radius ");
    if (isNaN(radius) || radius==='' || parseFloat(radius) < 0 ){
        return ;
    }
    let area = Math.PI * Math.pow(parseFloat(radius), 2);
    alert (" Area "+area.toFixed(2))
} 
//2
function  squareRoot () {
    let x = prompt("Enter number  ");
    if (isNaN(x) || x < 0) {
        return ;
    }
    let ans = Math.sqrt(parseFloat(x));
        alert("Square root of " + x + " is " + ans.toFixed(2));
}

//3
function cos() {
    let x = prompt("Enter an angle ");
    let degrees = parseFloat(x);
    if (isNaN(degrees)) {
        return;
    }
    let radians = degrees * (Math.PI / 180);
    let cosValue = Math.cos(radians);
    alert(" cos is "+ cosValue.toFixed(2));
}

squareRoot()
// 
cos()
circleArea()
// userInfo()
// largestString()
// palindrome()
// numOfletters ()