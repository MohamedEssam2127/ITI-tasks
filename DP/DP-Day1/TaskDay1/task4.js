class NormalSquare {
  draw() {
    console.log("Drawing a Regular Square");
  }
}

class NormalRectangle {
  draw() {
    console.log("Drawing a Regular Rectangle");
  }
}

class RoundedSquare {
  draw() {
    console.log("Drawing a Rounded Square");
  }
}

class RoundedRectangle {
  draw() {
    console.log("Drawing a Rounded Rectangle");
  }
}

class RegularShapeFactory {
  createSquare() {
    return new NormalSquare();
  }

  createRectangle() {
    return new NormalRectangle();
  }
}

class RoundedShapeFactory {
  createSquare() {
    return new RoundedSquare();
  }

  createRectangle() {
    return new RoundedRectangle();
  }
}

function renderShapes(factory) {
  const square = factory.createSquare();
  const rectangle = factory.createRectangle();

  square.draw();
  rectangle.draw();
}

console.log("--- Regular Shapes ---");
renderShapes(new RegularShapeFactory());

console.log("\n--- Rounded Shapes ---");
renderShapes(new RoundedShapeFactory());