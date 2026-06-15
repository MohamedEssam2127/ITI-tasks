import 'dart:async';
import 'dart:convert';
import 'package:http/http.dart' as http;

void main(List<String> arguments) async {

//========================Q1========================

//============TASK1 

// Part 1: Version constraint ^2.4.5

// Minimum inclusive version: 2.4.5
// Maximum exclusive version: 3.0.0
// Allowed range: >=2.4.5 <3.0.0

// Part 2: Version constraint ^0.4.5

// Minimum inclusive version: 0.4.5
// Maximum exclusive version: 0.5.0
// Allowed range: >=0.4.5 <0.5.0

// Part 3: Exact version syntax

// Exact version:
// path: 1.9.0

// Explicit range syntax:
// path: '>=1.9.0 <2.0.0'

//============TASK2
// 1. Add dio package
// dart pub add dio

// 2. Pull and resolve dependencies
// dart pub get

//========================Q2========================

//============TASK1

// 1 & 2. Timeline & Queue Execution Trace:
// Main Thread (Sync Block):
// - Prints "Alpha" immediately.
// -  Future()  into the Event Queue.
// -  scheduleMicrotask()  into the Microtask Queue.
// -  Future.microtask()  into the Microtask Queue.
// - Prints "Epsilon" immediately.
//
// Microtask Queue (Runs right after ):
// - Dequeues and prints "Gamma".
// - Dequeues and prints "Delta".
//
// Event Queue (Runs after Microtasks ):
// - Dequeues and prints "Beta".

// 3. Expected Console Output:
// Alpha
// Epsilon
// Gamma
// Delta
// Beta

//============TASK2
  await runWait();
  await runRecords();

//============TASK3
  await for (var val in getStream()) {
    print(val);
  }

//========================Q3========================

//============TASK1
  var item = InvoiceItem("tablet", 3000, 200);
  print(item.totalCost);
  print(InvoiceItem.calculateVat(item.totalCost));

//============TASK2
  var u1 = UserAccount();
  var u2 = UserAccount.secured("Mod");
  var u3 = UserAccount.fromMap({"name": "mohamed Essam", "isAdmin": true});
  print(u3.name);

//============TASK3
  const c1 = Coordinates(12.5, 25.0);
  const c2 = Coordinates(12.5, 25.0);
  print(identical(c1, c2));

//========================Q4========================

//============TASK1
  var v = Vault();
  v.balance = 5000;
  print(v.balance);

//============TASK2
  NotificationChannel ch = EmailChannel();
  ch.send();
  ch.show();

//============TASK3
  var client = CustomAuth();
  client.login();

//============TASK4
  print("DartLang".checkLength);
  var staff1 = Worker(5, "Mona");
  var staff2 = Worker(5, "Mona");
  print(staff1 == staff2);

//========================Q5========================

//============TASK1

  
// interface: can implement only
// base: can extend with restrictions
// final: cannot be extended or implemented outside library
// sealed: enables exhaustive switch checking


//============TASK2
  await fetchWebPosts();
}

// Q2: Methods Definitions 
// =================================================

Future<String> getData1() async {
  await Future.delayed(Duration(seconds: 1));
  return "Data1";
}

Future<String> getData2() async {
  await Future.delayed(Duration(seconds: 1));
  return "Data2";
}

Future<void> runWait() async {
  try {
    var res = await Future.wait([
      getData1().timeout(Duration(seconds: 3)),
      getData2().timeout(Duration(seconds: 3)),
    ]);
    print(res);
  } on TimeoutException {
    print("Timeout");
  }
}

Future<void> runRecords() async {
  try {
    var (r1, r2) = await (
      getData1().timeout(Duration(seconds: 3)),
      getData2().timeout(Duration(seconds: 3)),
    ).wait;
    print(r1);
    print(r2);
  } on TimeoutException {
    print("Timeout");
  }
}

Stream<int> getStream() async* {
  for (int i = 1; i <= 5; i++) {
    await Future.delayed(Duration(seconds: 1));
    yield i;
  }
}


// Q3: Classes Definitions
// =================================================

class InvoiceItem {
  final String description;
  final double baseCost;
  final double markup;
  final double totalCost;

  InvoiceItem(this.description, this.baseCost, this.markup)
      : totalCost = baseCost + markup;

  static double calculateVat(double amount) {
    return amount * 0.14;
  }
}

class UserAccount {
  String name;
  bool isAdmin;

  UserAccount([this.name = "Guest", this.isAdmin = false]);

  UserAccount.secured(this.name) : isAdmin = true;

  factory UserAccount.fromMap(Map<String, dynamic> data) {
    return UserAccount(
      data["name"] as String,
      data["isAdmin"] as bool,
    );
  }
}

class Coordinates {
  final double x;
  final double y;

  const Coordinates(this.x, this.y);
}

// Q4: Classes and Structural Definitions
// =================================================

class Vault {
  double _balance = 0.0;

  double get balance => _balance;
  set balance(double val) {
    if (val >= 0) {
      _balance = val;
    }
  }
}

abstract class NotificationChannel {
  void send();
  void show() {
    print("Default Display");
  }
}

class EmailChannel extends NotificationChannel {
  @override
  void send() {
    print("Email Sent");
  }

  @override
  void show() {
    print("Email Display");
  }
}

class PlainLogger {
  void logMsg(String msg) {
    print(msg);
  }
}

class SystemLogger implements PlainLogger {
  @override
  void logMsg(String msg) {
    print("Log: $msg");
  }
}

mixin SimpleLogger {
  void info(String message) {
    print("INFO: $message");
  }
}

abstract class BaseAuth {
  void login();
}

mixin GuardedLog on BaseAuth {
  void track(String action) {
    print("Action Tracked: $action");
  }
}

class CustomAuth extends BaseAuth with GuardedLog {
  @override
  void login() {
    track("User Login Attempt");
  }
}

extension ValueValidation on String {
  bool get checkLength => trim().length > 6;
}

class Worker {
  final int id;
  final String title;

  Worker(this.id, this.title);

  @override
  bool operator ==(Object other) {
    return other is Worker && other.id == id && other.title == title;
  }

  @override
  int get hashCode => Object.hash(id, title);
}

// Q5: API Service Implementation
// =================================================

Future<void> fetchWebPosts() async {
  try {
    var response = await http.get(
      Uri.parse('https://jsonplaceholder.typicode.com/posts'),
    );

    if (response.statusCode == 200) {
      List<dynamic> parsedList = jsonDecode(response.body);
      print("Items retrieved: ${parsedList.length}");
    } else {
      print("Failed Response");
    }
  } catch (err) {
    print("Error caught: $err");
  } finally {
    print("Operation Cleared");
  }
}