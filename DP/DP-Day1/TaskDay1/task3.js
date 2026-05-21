// task 3 builder 
class Pizza {
    constructor() {
        this.crust = "classic";
        this.sauce = "tomato";
        this.cheese = "mozzarella";
        this.toppings = [];
        this.size = "medium";
    }
}

class PizzaBuilder {
    constructor() {
        this.pizza = new Pizza();
    }

    addCrust(type) {
        this.pizza.crust = type;
        return this;
    }

    addSauce(type) {
        this.pizza.sauce = type;
        return this;
    }

    addCheese(type) {
        this.pizza.cheese = type;
        return this;
    }

    addTopping(topping) {
        this.pizza.toppings.push(topping);
        return this;
    }

    setSize(size) {
        this.pizza.size = size;
        return this;
    }

    build() {
        return this.pizza;
    }
}

const myPizza = new PizzaBuilder().addCrust("thin").addCheese("cheddar").addTopping("pepperoni")
.addTopping("mushrooms").setSize("large").build();
console.log(myPizza);