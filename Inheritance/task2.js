function Vehicle(speed ,color){
    // if (this.constructor === Vehicle) {
    //     throw new Error("Abstract class");
    // }
    if(typeof speed !=='number' ||typeof color !=='number' ){
        throw new Error('invalid data type')
    }
    var speed = speed
    Object.defineProperty(this,'speed',{
        get: function(){
             return speed;
        }
    })

    var color = color ;
     Object.defineProperty(this,'color',{
        get: function(){
             return color;
        }
    })
}

Vehicle.prototype.turnLeft =function () {
    console.log('turnLeft')
}
Vehicle.prototype.turnRight =function () {
    console.log('turnRight')
}
Vehicle.prototype.start =function () {
    console.log('start')
    return true
}
Vehicle.prototype.stop =function () {
    console.log('stop')
    return false;
}

Vehicle.prototype.goBackWard =function (speed,accel) {
    console.log('goBackWard')
}
Vehicle.prototype.goForWard =function (speed,accel) {
    console.log('goForWard')
}

function Bicycle (speed ,color){
    Vehicle.call(this , speed ,color)
}

Bicycle.prototype = Object.create(Vehicle.prototype)
Bicycle.prototype.constructor = Bicycle

Bicycle.prototype.ringBell = function (){
    console.log('ringBell')
}
Bicycle.prototype.toString = function (){
     console.log('Bicycle')
}
function MotorVehicle (speed ,color ,sizeOfEngine , licencePlate){
     Vehicle.call(this , speed ,color)
     if(typeof licencePlate !== 'string' ||typeof sizeOfEngine !=='number' ){
        throw new Error('invalid data type')
    }

     var sizeOfEngine = sizeOfEngine
    Object.defineProperty(this,'sizeOfEngine',{
        get: function(){
             return sizeOfEngine;
        }
    })

    var licencePlate = licencePlate ;
     Object.defineProperty(this,'licencePlate',{
        get: function(){
             return licencePlate;
        }
    })
}

MotorVehicle.prototype = Object.create(Vehicle.prototype)
MotorVehicle.prototype.constructor = MotorVehicle

MotorVehicle.prototype.getSizeOfEngine = function (){
    console.log('getSizeOfEngine')
}
MotorVehicle.prototype.getlicencePlate = function (){
    console.log('getlicencePlate')
}


function Car (speed ,color ,sizeOfEngine , licencePlate ,doors ,wheels,weight){
    MotorVehicle.call (this,speed ,color ,sizeOfEngine , licencePlate)
     if(typeof doors !== 'number' ||
        typeof wheels !=='number' ||
        typeof weight !=='number'){
        throw new Error('invalid data type')
    }
    var doors = doors 
    Object.defineProperty(this,'doors',{
        get: function(){
             return doors;
        }
    })

    var wheels = wheels 
     Object.defineProperty(this,'wheels',{
        get: function(){
             return wheels;
        }
    })

      var weight = weight 
     Object.defineProperty(this,'weight',{
        get: function(){
             return weight;
        }
    })
}

Car.prototype = Object.create(MotorVehicle.prototype)
Car.prototype.constructor = Car

Car.prototype.switchOnAirCon= function () {
     console.log('switchOnAirCon')
}
Car.prototype.getNumOfDoor= function () {
     console.log('getNumOfDoor')
}

Car.prototype.toString = function () {
    console,log('Car')
}
Car.prototype.valueOf= function (){
    return 'Car'
}


function DumpTruck (speed ,color ,sizeOfEngine , licencePlate ,loadCapacity ,wheels,weight){
    MotorVehicle.call (this,speed ,color ,sizeOfEngine , licencePlate)
     if(typeof loadCapacity !== 'number' ||
        typeof wheels !=='number' ||
        typeof weight !=='number'){
        throw new Error('invalid data type')
    }
    var loadCapacity = loadCapacity 
    Object.defineProperty(this,'loadCapacity',{
        get: function(){
             return loadCapacity;
        }
    })

    var wheels = wheels 
     Object.defineProperty(this,'wheels',{
        get: function(){
             return wheels;
        }
    })

      var weight = weight 
     Object.defineProperty(this,'weight',{
        get: function(){
             return weight;
        }
    })
}

DumpTruck.prototype = Object.create(MotorVehicle.prototype)
DumpTruck.prototype.constructor = DumpTruck

DumpTruck.prototype.lowerLoad= function () {
     console.log('switchOnAirCon')
}
DumpTruck.prototype.raiseLoad= function () {
     console.log('raiseLoad')
}

DumpTruck.prototype.toString = function () {
    console,log('DumpTruck')
}
DumpTruck.prototype.valueOf= function (){
    return 'DumpTruck'
}
let c1 = new Car(
    120,1,12,'2',1,1,1
);
c1
