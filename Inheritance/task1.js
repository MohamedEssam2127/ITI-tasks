function Shape() {
    if (this.constructor === Shape) {
        throw new Error("Abstract class");
    }
}

Shape.prototype.area = function () {
    throw new Error("Must be implemented");
};

Shape.prototype.perimeter = function () {
    throw new Error("Must be implemented");
};



function Rectangle ( w , h){
    if(w <0 || h < 0){
        throw new Error ('width & height must be +ve ')
    }
     if(Rectangle.counter===1 && this.constructor == Rectangle){
        throw new Error ('only one instance form Rectangle ')
    }
    Shape.call(this)
    var width = w 
    Object.defineProperty(this,'width',{
        get:function(){
            return width
        },
    })

    var height = h 
    Object.defineProperty(this,'height',{
        get: function (){
            return height
        },
    })
    Rectangle.counter++
}
Rectangle.prototype = Object.create(Shape.prototype)
Rectangle.prototype.constructor = Rectangle

Rectangle.prototype.area = function (){
    return this.width * this.height
}
Rectangle.prototype.perimeter = function(){
    return 2* (this.width + this.height)
}
Rectangle.prototype.toString= function (){
    return " Area : " + this.area() +"  perimeter : "+ this.perimeter() + ' width : '+ this.width + ' height : '+ this.height
}
Rectangle.prototype.valueOf= function (){
    return this.area()
}
Rectangle.counter=0

function Square (l) {
    if(Square.counter===1 && this.constructor == Square){
        throw new Error ('only one instance  Shape')
    }
    Rectangle.call(this,l,l)
    Square.counter++;
}

Square.counter = 0;
Square.prototype= Object.create(Rectangle.prototype)
Square.prototype.constructor = Square
Square.prototype.toString= function (){
    return " Area : " + this.area() +"  perimeter : "+ this.perimeter() + ' width : '+ this.width 
}

let r1 = new Rectangle(3,3)
// let r2 = new Rectangle (3,3)
let s1= new Square(1)
// let s2= new Square(1)

console.log(Square.counter)
console.log(s1.toString())

console.log(r1+s1)