import 'package:task2/task2.dart' as task2;

void main() {
  print("==============Q1============== \n");
  // =====task 1 =====
  final nums1 = [1, 2, 3, 4]; //can add
  nums1.add(5);
  print(nums1);

  const nums2 = [1, 2, 3, 4]; //can't add
  //nums2.add(5);   print(nums2);  Cannot add to an unmodifiable list

  // =====task 2 =====
  final a = [1, 2, 3, 4];
  final b = [1, 2, 3, 4];
  print(
    identical(a, b),
  ); // false because they are different instances in memory
  const c = [1, 2, 3, 4];
  const d = [1, 2, 3, 4];
  print(
    identical(c, d),
  ); // true because they are compile-time constants and refer to the same instance in memory
  // =====task 3 =====

  Object var1 = "Hello";
  dynamic var2 = "Hello";

  var1 = 100;
  var2 = 100;
  print("==============Q2============== \n");

  //task 1
  var (:lat, :lon) = processCoordinates();

  print('Latitude: $lat');
  print('Longitude: $lon');

  //task2

  Object payload = ('Mohamed', 22);
  switch (payload) {
    case (String name, int age):
      print('User Name: $name, Age: $age');
    case [int a, int b]:
      print(a + b);
    case int value when value % 5 == 0:
      print('Multiple of 5: $value');
    default:
      print('Unmatched payload');
  }

  print("==============Q3============== \n");

  ///task 1
  String? companyName = null;
  print(companyName?.length);

  String company = companyName ?? "Default Corporate";
  print(company);

  String? department;
  department ??= "Engineering";
  print(department);
  // task 2
  int score = 50;
  int result = ++score + score++;
  print('Result: $result');
  print('Score: $score');

  //tASK 3
  List<String> stages = ["Build", "Test", "Deploy"];
  bool isProduction = true;

  List<String> pipeline = [
    "Initialize",
    ...stages,
    if (isProduction) "Security Scan",
    "Clean",
  ];

  List<String> upperPipeline = [
    for (var stage in pipeline) stage.toUpperCase(),
  ];

    print(upperPipeline);

  print("==============Q4============== \n");
// task 1
    List<int> numbers = [10, 50, 70, 20, 40];
  
  final filtered = List.unmodifiable(numbers.where((value) => value >= 50));
  print("Filtered & Unmodifiable: $filtered");

  final reversedList = filtered.reversed.toList();
  print("Inverted Order: $reversedList");
  print("Source Reference Untouched: $numbers");
  //task 2

    Map<String, int> inventory = {
    'P001': 120,
    'P002': 75,
    'P003': 30,
  };

 
  inventory.putIfAbsent('P004', () => 50);

  inventory.putIfAbsent('P001', () => 999);

  print(inventory);

  for (var key in inventory.keys) {
    print(key);
  }

  for (var value in inventory.values) {
    print(value);
  }
  print("==============Q5============== \n");

  //task 1

  configureAlert(message: "System Started");

  configureAlert(
    message: "Disk Space Low",
    level: "WARNING",
  );

  //task2

  var updateVelocity = trackVelocity();
  updateVelocity(10);
  updateVelocity(15);
  updateVelocity(5);

  /// task3 
  var wrappedQuery = profileExecution(executeDatabaseQuery);
  wrappedQuery();
}

({double lat, double lon}) processCoordinates() {
  return (lat: 30.4, lon: 31.2);
}
///q5 task1 
void configureAlert({
  required String message,
  String level = "INFO",
}) {
  print("[$level] $message");
}

// q 5 task2
Function trackVelocity() {
  int displacement = 0;
  
  return (int step) {
    displacement += step;
    print("Accumulated Velocity/Displacement: $displacement");
  };
}
//q 5 task3
void executeDatabaseQuery() {
  print("Query Executed");
} 

Function profileExecution(Function originalFunction) {
  return () {
    print("Timer Started");
    originalFunction();
    print("Timer Stopped");
  };
}


