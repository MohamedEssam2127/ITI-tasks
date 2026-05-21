//1- Singleton
class InstanceCounter {
  static instance = null;
  static count = 0;

  constructor() {
    if (InstanceCounter.instance) {
      InstanceCounter.count++;
      return InstanceCounter.instance;
    }

    InstanceCounter.instance = this;
    InstanceCounter.count = 1;
  }

  static getCount() {
    return InstanceCounter.count;
  }
}


class User {
  constructor() {
    new InstanceCounter();
  }
}

class Person {
  constructor() {
    new InstanceCounter();
  }
}

const a = new User();
console.log(InstanceCounter.getCount());
const b = new Person();
console.log(InstanceCounter.getCount());
const c = new Person();

console.log(InstanceCounter.getCount());