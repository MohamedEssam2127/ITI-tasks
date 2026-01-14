
function numSequence(start ,end , step){
    let list =[];
    if (step <=0){
        throw new Error(" step must be +ve")
    }

    function addData(){
        for(let i =start ; i<=end;i+=step){
            list.push(i)
        }
    }
    this.append = function (myval){
        if ( list[list.length-1]+step ===myval){
            list.push(myval);
        }else {
            console.log (list)
            throw new Error (" step not correct ")
        }
        
    }

    this.display = function (){
        let str = "";
        for (let i =0 ; i <list.length ;i++){
            str += list[i]+" "
        }
        console.log(str)
    }

    this.prepend = function(myval){
        if ( list[0]-step ===myval){
            list.unshift(myval);
        }else {
            throw new Error (" step not correct ")
        }
    }

    this.dequeue = function () {
        if(list.length===0){
            throw new Error ("the list is empty")
        }else {
            list.shift();
        }
    }

      this.pop = function () {
        if(list.length===0){
            throw new Error ("the list is empty")
        }else {
            list.pop();
        }
    }

    addData()
}

var x = new numSequence(0,10,2);
x.display() // 0 2 4 6 8 10 
x.append(12) //0 2 4 6 8 10 12 
x.display() 
x.pop() // 0 2 4 6 8 10
x.pop() // 0 2 4 6 8 
x.pop() // 0 2 4 6 
x.dequeue()  // 2 4 6
x.prepend(0) // 0 2 4 6 
x.display()
