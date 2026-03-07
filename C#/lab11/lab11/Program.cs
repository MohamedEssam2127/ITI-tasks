using L2O___D09;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Threading;
using System.Xml.Linq;
using  static L2O___D09.ListGenerators;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Where 
            ///1 - out of stock
            //var R = ProductList.Where(P=>P.UnitsInStock==0);
            //foreach (var unit in R) { 
            // Console.WriteLine(unit);
            //}

            /// 2 Find all products that are in stock and cost more than 3.00 per unit.
            //var R = ProductList.Where(P => P.UnitsInStock >= 0 && P.UnitPrice > 3);
            //foreach (var unit in R)
            //{
            //    Console.WriteLine(unit);
            //}

            ///3 Returns digits whose name is shorter than their value
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var R =  Arr.Where((X,i) => X.Length  <  i);
            //foreach (var num in R)
            //{
            //    Console.WriteLine(num);
            //}

            #endregion
            //--------------------------------------------------

            #region first 
            ///1 . Get first Product out of Stock
            //var Res = ProductList.FirstOrDefault(P => P.UnitsInStock == 0);
            //Console.WriteLine(Res);

            ///2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var res = ProductList.FirstOrDefault(p=>p.UnitPrice > 1000);
            //Console.WriteLine(res?.ProductName ?? "No product found");


            //3.Retrieve the second number greater than 5
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(x => x > 5).Where((x, i) => i == 1).FirstOrDefault();

            //Console.WriteLine(result);



            #endregion
            //--------------------------------------------------
            #region Order 
            /// 1.Sort a list of products by name

            //var res = ProductList.OrderBy(p=>p.ProductName);
            //foreach (var x in res)
            //{
            //    Console.WriteLine(x.ProductName);
            //}

            ///2.Uses a custom comparer to do a case -insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };


            //var sorted = Arr.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in sorted)
            //{
            //    Console.WriteLine(word);
            //}


            ///3 Sort a list of products by units in stock from highest to lowest

            //var res3 = ProductList.OrderByDescending(p => p.UnitsInStock);

            //foreach (var p in res3)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitsInStock}");
            //}

            ///4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var res4 = Arr.OrderBy(w => w.Length).ThenBy(w => w);

            //foreach (var word in res4)
            //{
            //    Console.WriteLine(word);
            //}

            ///5 Sort first by word length and then by a case-insensitive sort of the words in an array.
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var res5 = words.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in res5)
            //{
            //    Console.WriteLine(word);
            //}

            ///6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var res6 = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            //foreach (var p in res6)
            //{
            //    Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");
            //}


            ///7.Sort first by word length and then by a case -insensitive descending sort of the words in an array.

            //string[] Arr2 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var res7 = Arr2
            //            .OrderBy(w => w.Length)
            //            .ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in res7)
            //{
            //    Console.WriteLine(word);
            //}

            ///8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr3 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var res8 = Arr3.Where(w => w.Length > 1 && w[1] == 'i').Reverse();

            //foreach (var word in res8)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            //--------------------------------------------------

            #region Projection

            ///1. Return a sequence of just the names of a list of products.
            //var res = ProductList.Select(p => p.ProductName);

            //foreach (var name in res1)
            //{
            //    Console.WriteLine(name);
            //}

            ///2. Produce uppercase and lowercase versions (Anonymous Type)
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var res = words.Select(w => new
            //{
            //    Upper = w.ToUpper(),
            //    Lower = w.ToLower()
            //});

            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item.Upper} - {item.Lower}");
            //}

            ///3. Select some properties and rename UnitPrice to Price

            //var res = ProductList.Select(p => new
            //{
            //    p.ProductName,
            //    p.Category,
            //    Price = p.UnitPrice
            //});

            //foreach (var p in res)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.Category} -    Price  {p.Price}");
            //}


            ///4. Determine if number matches its index

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res4 = Arr.Select((num, index) => new
            //{
            //    Number = num,
            //    InPlace = num == index
            //});

            //foreach (var item in res4)
            //{
            //    Console.WriteLine($"{item.Number}: {item.InPlace}");
            //}

            ///5. All pairs where a < b
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var res5 = numbersA
            //    .Select(a => numbersB
            //        .Where(b => a < b)
            //        .Select(b => new { a, b })
            //    );

            //Console.WriteLine("Pairs where a < b:");

            //foreach (var group in res5)
            //{
            //    foreach (var pair in group)
            //    {
            //        Console.WriteLine($"{pair.a} is less than {pair.b}");
            //    }
            //}

            ///6. Select all orders where total < 500

            //var res6 = CustomerList
            //    .Select(c => c.Orders
            //        .Where(o => o.Total < 500)
            //    );

            //foreach (var orders in res6)
            //{
            //    foreach (var order in orders)
            //    {
            //        Console.WriteLine($"{order.OrderID} - {order.Total}");
            //    }
            //}

            ///7. Select all orders made in 1998 or later

            //var res7 = CustomerList
            //    .Select(c => c.Orders
            //        .Where(o => o.OrderDate.Year >= 1998)
            //    );

            //foreach (var orders in res7)
            //{
            //    foreach (var order in orders)
            //    {
            //        Console.WriteLine($"{order.OrderID} - {order.OrderDate}");
            //    }
            //}

            #endregion

            //____----------------------------------__________
            /// NEW DAY 12 

            #region Set Operators
            //1.Find the unique Category names from Product List
            //var res = ProductList
            //    .Select(p => p.Category)
            //    .Distinct();

            //foreach (var category in res)
            //{
            //    Console.WriteLine(category);
            //}

            //2.Produce a Sequence containing the unique first letter from both product and customer names.

            //var productLetters = ProductList
            //    .Select(p => p.ProductName[0]);

            //var customerLetters = CustomerList
            //    .Select(c => c.CompanyName[0]);

            //var result = productLetters
            //    .Union(customerLetters);

            //foreach (var letter in result)
            //{
            //    Console.WriteLine(letter);
            //}

            //3.Create one sequence that contains the common first letter from both product and customer names.

            //var productLetters = ProductList.Select(p => p.ProductName[0]);

            //var customerLetters = CustomerList.Select(c => c.CompanyName[0]);

            //var result = productLetters.Intersect(customerLetters);

            //foreach (var letter in result)
            //{
            //    Console.WriteLine(letter);
            //}

            ///4.Create one sequence that contains the first letters of product names that are
            ///not also first letters of customer names.

            //var productLetters = ProductList.Select(p => p.ProductName[0]);

            //var customerLetters = CustomerList.Select(c => c.CompanyName[0]);

            //var result4 = productLetters.Except(customerLetters);

            //foreach (var letter in result4)
            //{
            //    Console.WriteLine(letter);
            //}

            ///5.Create one sequence that contains the last Three Characters in each names
            ///of all customers and products, including any duplicates

            //var productLast3 = ProductList
            //.Select(p => p.ProductName.Length >= 3 ? p.ProductName.Substring(p.ProductName.Length - 3) : p.ProductName);

            //var customerLast3 = CustomerList
            //    .Select(c => c.CompanyName.Length >= 3 ? c.CompanyName.Substring(c.CompanyName.Length - 3) : c.CompanyName);

            //var result5 = productLast3.Concat(customerLast3);

            //foreach (var s in result5)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion

            //____----------------------------------__________

            #region Aggregate Operators
            ///1.Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var r = Arr.Count(p=>p%2==1);
            //Console.WriteLine($" count {r}");

            ///2. Return a list of customers and how many orders each has.

            //var r = CustomerList.Select(c => new
            //                {
            //                 Customer = c.CompanyName,
            //                 OrderCount = c.Orders.Count()
            //                });

            //foreach (var item in r)
            //{
            //    Console.WriteLine($"{item.Customer} - {item.OrderCount}");
            //}

            /// 3.Return a list of categories and how many products each has


            //var result3 = ProductList.GroupBy(p => p.Category)
            //             .Select(g => new
            //             {
            //                 Category = g.Key,
            //                 ProductCount = g.Count()
            //             });

            //foreach (var item in result3)
            //{
            //    Console.WriteLine($"{item.Category} - {item.ProductCount}");
            //}

            ///4.Get the total of the numbers in an array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res  = Arr.Sum ();
            //Console.WriteLine (res);


            ///5. Get the total number of characters of all words in dictionary_english.txt 
            ///(Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var res = words.Sum(w => w.Length);
            //Console.WriteLine(res);

            ///6.Get the total units in stock for each product category. 

            //var res = ProductList
            // .GroupBy(p => p.Category)
            // .Select(g => new
            // {
            //     Category = g.Key,
            //     TotalUnits = g.Sum(p => p.UnitsInStock)
            // });

            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item.Category} : {item.TotalUnits}");
            //}


            ///7.Get the length of the shortest word in dictionary_english.txt
            ///(Read dictionary_english.txt into Array of String First).


            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var min = words.Min(w=>w.Length);

            //Console.WriteLine(min);

            ///8.Get the cheapest price among each category's products

            //var res = ProductList
            //.GroupBy(p => p.Category)
            //.Select(g => new
            //{
            //    Category = g.Key,
            //    CheapestPrice = g.Min(p => p.UnitPrice)
            //});

            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item.Category} : {item.CheapestPrice}");
            //}

            ///9. Get the products with the cheapest price in each category (Use Let)

            //var res9 =
            //   from p in ProductList
            //   group p by p.Category into g
            //   let minPrice = g.Min(x => x.UnitPrice)
            //   from p2 in g
            //   where p2.UnitPrice == minPrice
            //   select p2;

            // foreach (var p in res9)
            // {
            //     Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");
            // }

            ///10. Get the length of the longest word in dictionary_english.txt 
            ///(Read dictionary_english.txt into Array of String First).


            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var res = words.Max(w=>w.Length);
            //Console.WriteLine(res);

            ///11. Get the most expensive price among each category's products.


            //var res = ProductList.GroupBy(P => P.Category).
            //    Select(g => new
            //    {
            //        Category= g.Key,
            //        MaxPrice = g.Max(p=>p.UnitPrice)
            //    });

            //foreach (var group in res) {
            //    Console.WriteLine("=================================");

            //     Console.WriteLine($"group.Category {group.Category} :- Max price  {group.MaxPrice}");

            //}

            ///12.Get the products with the most expensive price in each category.

            //var res = ProductList
            //.GroupBy(p => p.Category)
            //.SelectMany(g =>
            //{
            //    var max = g.Max(p => p.UnitPrice);
            //    return g.Where(p => p.UnitPrice == max);
            //});

            //var res  = from p in ProductList
            //           group p  by p.Category into groups 
            //           let maxP= groups.Max(x => x.UnitPrice)
            //           from p2 in groups
            //           where p2.UnitPrice == maxP
            //           select p2;

            //foreach (var p in res)
            //{
            //    Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");
            //}






            ///13.Get the average length of the words in dictionary_english.txt
            ///(Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var avg  = words.Average(x => x.Length);
            //Console.WriteLine(avg);


            ///14.Get the average price of each category's products.

            //var avg2 = ProductList.GroupBy(P=>P.Category).
            //    Select(g=> new {
            //       Id = g.Key,
            //       Avg  =g.Average(P=> P.UnitPrice)
            //    });

            //foreach(var x  in avg2)
            //    Console.WriteLine( $" Category {x.Id}  - AVG {x.Avg}");

            #endregion

            //____----------------------------------__________

            #region Partitioning Operators

            /// 1.Get the first 3 orders from customers in Washington

            //var res = CustomerList
            // .Where(c => c.Region == "WA")
            // .SelectMany(c => c.Orders)
            //  .Take(3);

            //foreach (var order in res)
            //{
            //    Console.WriteLine(order);
            //}

            ///2.Get all but the first 2 orders from customers in Washington.

            //var res = CustomerList
            // .Where(c => c.Region == "WA")
            // .SelectMany(c => c.Orders)
            //  .Skip(2);

            //foreach (var order in res)
            //{
            //    Console.WriteLine(order);
            //}


            ///3.Return elements starting from the beginning of the array until a
            ///number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var resault = numbers.TakeWhile((n, i) => n >= i);

            //foreach (var n in resault)
            //{
            //    Console.WriteLine(n);
            //}



            ///  4.Get the elements of the array starting from the first element divisible by 3.


            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile(n => n % 3 != 0);

            //foreach (var n in result)
            //{
            //    Console.WriteLine(n);
            //}

            /// 5.Get the elements of the array starting from the first element less than its position.
            // int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile((n, index) => n >= index);

            //foreach (var n in result)
            //{
            //    Console.WriteLine(n);
            //}

            #endregion


            //____----------------------------------__________
            #region Partitioning Operators
            ///1.Determine if any of the words in dictionary_english.txt
            ///(Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //string[] words  = File.ReadAllLines("dictionary_english.txt");

            //var res = words.Any(w=>w.Contains("ei"));
            //Console.WriteLine(res);

            ///2.Return a grouped a list of products only for categories that have at
            ///least one product that is out of stock.

            //var result = ProductList.GroupBy(p => p.Category)
            //            .Where(g => g.Any(p => p.UnitsInStock == 0));

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"   {product}");
            //    }
            //}

            ///3.Return a grouped a list of products only for categories that have all of their products in stock.
            ///
            //var result = ProductList.GroupBy(p => p.Category)
            //            .Where(g => g.All(p => p.UnitsInStock > 0));

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"   {product}");
            //    }
            //}

            #endregion

            //____----------------------------------__________

            #region Gruping

            ///1

            //int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var groups = numbers.GroupBy(n => n % 5);

            //foreach (var group in groups)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5:");
            //    foreach (var n in group)
            //    {
            //        Console.WriteLine(n);
            //    }
            //}


            ///2


            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var wordGroups = words
            //    .GroupBy(w => char.ToUpper(w[0]));

            //foreach (var group in wordGroups)
            //{
            //    Console.WriteLine($".... {group.Key} ....");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}

            ///3
            //string[] Arr = { "from  ", " salt", " earn ", "  last  ", " near ", " form " };

            //var anagramGroups = Arr.GroupBy(w => new string(w.Trim().OrderBy(c => c).ToArray()));

            //foreach (var group in anagramGroups)
            //{
            //    Console.WriteLine("...");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word.Trim());
            //    }
            //}



            #endregion
        }
    }

}
