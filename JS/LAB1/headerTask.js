// 1
function headerloop(){
    for( let i =1 ;i <7;i++){
       let x =  prompt(`enter header number ${i} `, `header number ${i} `);
        document.writeln(`<h${i}>  ${x} </h${i}> ` );
    }
}



//---------------

// 2 
function sum () {
    let sum = 0;
    let x ;
    while (true){
        if (sum > 100 ) {
            break ;
        }
          x =prompt(' enter number', '0') ;
         if (x == '0' ){
            break ;
         }
         if ( isNaN(x) || x === ''){
            alert(" enter numbers only ! ");
            continue ;
         }
         sum = sum + parseInt(x) 
    }
    console.log( "the sum is  "+sum )

}

//3 

function max (){
    let a = parseInt(prompt("Enter first number"));
    let b = parseInt(prompt("Enter second number"));

let max = (a > b) ? a : b;

console.log("max value is "+ max )

}

//4
function divisible (){
    let x = prompt("enter x ")
    let y = prompt("enter y ")
    let z = prompt("enter z ")

    if (x==='' ||y==='' ||z===''|| isNaN(x) ||isNaN(y) || isNaN(z)){
        alert(" enter numbers only !")
    }else{
        if ( x % y==0 || x % z ==0 ) {
            if ( x % y ==0 && x % z==0){
                console.log( `${x} divisable by both  ${y} and ${z}`)
            }else {
                    if(x % y ===0){
                        console.log( `${x} divisable by ${y}`)
                    }
                    if(x % z ===0){
                        console.log( `${x} divisable by ${z}`)
                    }
            }
        }else {
            console.log(`${x} is not divisable by both ${y} nor ${z}`)
        }
        
    }
}



// 5
function multiples3And5 () {
    let x = prompt("enter start ");
    let y = prompt("enter end ");
    if (x === '' || y === '' || isNaN(x) || isNaN(y)) {
        alert("enter numbers only !");
        return;
    } 
    let start = parseInt(x);
    let end = parseInt(y);
    let mul3 = "";
    let mul5 = "";
    let sum = 0;
    for (; start <= end; start++) {
        let isAdded = false;
        if (start % 3 === 0) {
            mul3 += (mul3 === "" ? "" : ",") + start;
            sum += start;
            isAdded = true;
        }
        if (start % 5 === 0) {
            mul5 += (mul5 === "" ? "" : ",") + start;
            if (!isAdded) {
                sum += start;
            }
        }
    }
    console.log("Number multiple of 3: " + mul3);
    console.log("Number multiple of 5: " + mul5);
    console.log("total sum is " + sum);
}

//6 
function pattern (){
    let row  = prompt("enter number for pattern ");
    let ans  = ""
   if (row==='' || isNaN(row)) {
        alert(" enter numbers only !")
        return ;
    } 
    let r = parseInt(row);
    for(let x  = 0;  x < r;x++){
      for (let y = 0; y <= x; y++){
            ans = ans + "*"
        }
        ans = ans + "\n"
    }
    console.log(ans)
    
}

// 7
function number7 (){
    let x = prompt("enter x ")
    let y = prompt("enter y ")
      if (x === '' || y === '' || isNaN(x) || isNaN(y)) {
          console,log("invalid input "); 
        return ;
    } 
    let z = prompt("enter z ")
    z = z.toLowerCase();
    let ans = ""; 


    if (z !== "odd" && z !== "even" && z !== "no"){
        console,log("invalid input "); 
        return; 
    }

    let start = parseInt(x);
    let end = parseInt(y);

    switch(z){
        case 'odd' : {
            if (start < end) {
                for (let i = start; i <= end; i++) {
                    if (i % 2 !== 0) {
                    if (ans === "") 
                        { ans = ans + i }
                        else {
                          ans = ans + " , " + i 
                          }
                    }
                }
            } else {
                for (let i = start; i >= end; i--) {
                    if (i % 2 !== 0) {
                    if (ans === "")
                             { ans = ans + i }
                        else {
                            ans = ans + " , " + i 
                             }
                    }
                }
            }
            console.log("%c" + ans, "color: green; ");
              break; 
        }
        case 'even' : {
            if(start < end){
                for(let i = start; i <= end; i++){
                    if( i % 2 === 0 ){
                        if (ans === "") 
                            { ans = ans + i }
                        else { ans = ans + " , " + i }
                    }
                }
            } else {
                for(let i = start; i >= end; i--){
                    if( i % 2 === 0 ){
                        if (ans === "") 
                            { ans = ans + i }
                        else { ans = ans + " , " + i }
                    }
                }
            }
            console.log("%c" + ans, "color: blue; ");
             break;
        }
        case 'no' : {
            if(start < end){
                for(let i = start; i <= end; i++){

                    if (ans === "") {
                         ans = ans + i }

                    else { ans = ans + " , " + i }
                }
            } else {
                for(let i = start; i >= end; i--){
                    if (ans === "") { ans = ans + i }
                    else { ans = ans + " , " + i }
                }
            }
            console.log("%c" + ans, "color: red; ");
             break;
        }
    }
  
}
//  headerloop();
//  sum()
// max()
// divisible()
// multiples3And5()
// pattern()
// number7()