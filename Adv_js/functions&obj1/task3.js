myObj = {
    id: 1,
    name: "essam",
    getSetGen: function () {
        var keys = Object.keys(this);
        for (var i = 0; i < keys.length; i++) {
            if (typeof this[keys[i]] !== 'function') {
                (function (j) {
                    var propertyName = keys[j];
                    this['set' + propertyName] = function (val) {
                        this[propertyName] = val;
                    };
                        this['get' + propertyName] = function () {
                        return this[propertyName];
                    };
                }).call(this, i); 
            }
        }
    }
}


// myObj.getSetGen();
// console.log("Before: ", myObj.id);
// myObj.setid(11);
// console.log("After setid(11): ", myObj.getid());
// console.log("Get Name: ", myObj.getname());


// user = { name: "Ali", age:10} 
// myObj.getSetGen.call(user);

// user.setname("Ahmed");
// console.log(user.getname()); 
// user.set
// console.log(user.getage());  
