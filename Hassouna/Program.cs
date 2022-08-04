using System;
// print in c#  
// Console.WriteLine("Hello");
// System.Console.WriteLine(77.99f);
// System.Console.WriteLine(true);
// System.Console.WriteLine(false);
// System.Console.WriteLine("hello \'amr\'");
// System.Console.WriteLine("hi {0}", "Ahmad");
// System.Console.WriteLine("salary is {0} $", 300.5f);
// System.Console.WriteLine("Name {0} ,age {1}", "Ali", 25);
// System.Console.WriteLine(System.DateTime.Now);
// System.Console.WriteLine("Amount is : {0:c1}", 99.99f);
// System.Console.WriteLine("Amount is : {0:c3}", 99.99f);// 3 digits
// System.Console.WriteLine("Amount is : {0:c5}", 99.99f);//5 digits
// System.Console.WriteLine("{0:d}", System.DateTime.Now);
// System.Console.WriteLine("{0:dd}", System.DateTime.Now);
// System.Console.WriteLine("{0:mm}", System.DateTime.Now);
// System.Console.WriteLine("{0:yyyy}", System.DateTime.Now);
// System.Console.WriteLine("{0:yy}", System.DateTime.Now);
// System.Console.WriteLine("{0:hh}", System.DateTime.Now);
// System.Console.WriteLine("{0:mm}", System.DateTime.Now);
// System.Console.WriteLine("{0:ss}", System.DateTime.Now);
// System.Console.WriteLine("{0:tt}", System.DateTime.Now);
// System.Console.WriteLine("{0,3}{0,9}{0,23}","Hi");// print formatted text
// System.Console.WriteLine("{0,-10}{0,-10}{0,-10}","Hi");
// System.Console.WriteLine("{0:n}",100000);
// System.Console.WriteLine("{0:NO}",100000);
// System.Console.WriteLine("{0:NS}",100000);
// System.Console.WriteLine("{0:G}:{0:x}",255);
//string Concat
// System.Console.WriteLine("Hello "+"Nasr");
// System.Console.WriteLine(string.Concat("Hello "+"Nasr"));
// System.Console.WriteLine(string.Concat("Hello "+"Nasr ",true));
//Math
// System.Console.WriteLine(12+4);
// System.Console.WriteLine(12-4);
// System.Console.WriteLine(12*4);
// System.Console.WriteLine(12/4);
// System.Console.WriteLine(12%7);
// System.Console.WriteLine(Math.Abs(-12));
// System.Console.WriteLine(Math.Cbrt(27));
// System.Console.WriteLine(Math.Ceiling(2.6));
// System.Console.WriteLine(Math.Floor(2.6));

// string name1 ="Amr", name2="Ali", name3="ezz"; // declare more vars in one shot
// System.Console.WriteLine(name1+' '+name2 +' '+name3);

// vars

// int num=9; string nam="Nasr"; double salary=199f;
// bool Isactive=true; char chaR='@'; ushort num2= 65535;
// System.Console.WriteLine("{0} {1}", num, nam);
// System.Console.WriteLine(salary);
// System.Console.WriteLine(Isactive);
// System.Console.WriteLine(chaR);
// System.Console.WriteLine(num2);
// long bigNum=777_000_000_999_333;
// System.Console.WriteLine(bigNum.ToString("#,#"));

// Post fix and prefix

// int x=4;
// int y=x++;
// System.Console.WriteLine("y= "+ y);
// System.Console.WriteLine("x= "+ x);
// int m=4;
// int n=--m;
// System.Console.WriteLine("m= "+ m);
// System.Console.WriteLine("n= "+ n);

//Print

// string str = string.Format("{0,15:E3}{0,15:e5}",333.555555);
// System.Console.WriteLine(str);

// String format

// DateTime birthdate = new DateTime(1993, 7, 28);
// DateTime[] dates = { new DateTime(1993, 8, 16), 
//                      new DateTime(1994, 7, 28), 
//                      new DateTime(2000, 10, 16), 
//                      new DateTime(2003, 7, 27), 
//                      new DateTime(2007, 5, 27) };

// foreach (DateTime dateValue in dates)
// {
//    TimeSpan interval = dateValue - birthdate;
//    // Get the approximate number of years, without accounting for leap years.
//    int years = ((int) interval.TotalDays) / 365;
//    // See if adding the number of years exceeds dateValue.
//    string output;
//    if (birthdate.AddYears(years) <= dateValue) {
//       output = String.Format("You are now {0} years old.", years);
//       Console.WriteLine(output);
//    }   
//    else {
//       output = String.Format("You are now {0} years old.", years - 1);
//       Console.WriteLine(output);
//    }      
// }
// // The example displays the following output:
// //       You are now 0 years old.
// //       You are now 1 years old.
// //       You are now 7 years old.
// //       You are now 9 years old.
// //       You are now 13 years old.

// Get started with the String.Format method
// Use String.Format if you need to insert the value of an object, variable, or expression into another string. For example, you can insert the value of a Decimal value into a string to display it to the user as a single string:

// Decimal pricePerOunce = 17.36m;
// String s = String.Format("The current price is {0} per ounce.",
//                          pricePerOunce);
// Console.WriteLine(s);
// // Result: The current price is 17.36 per ounce.

//And you can control that value's formatting:
// Decimal pricePerOunce = 17.36m;
// String s = String.Format("The current price is {0:C2} per ounce.",
//                          pricePerOunce);
// Console.WriteLine(s);
// Result if current culture is en-US:
//      The current price is $17.36 per ounce.


// Besides formatting, you can also control alignment and spacing.

// Insert a string
// String.Format starts with a format string, followed by one or more objects or expressions that will be converted to strings and inserted at a specified place in the format string. For example:

// decimal temp = 20.4m;
// string s = String.Format("The temperature is {0}°C.", temp);
// Console.WriteLine(s);
// // Displays 'The temperature is 20.4°C.'


// string s = String.Format("At {0}, the temperature is {1}°C.",
//                          DateTime.Now, 20.4);
// Console.WriteLine(s);
// // Output similar to: 'At 4/10/2015 9:29:41 AM, the temperature is 20.4°C.'

// //Control formatting
// You can follow the index in a format item with a format string to control how an object is formatted. For example, {0:d} applies the "d" format string to the first object in the object list. Here is an example with a single object and two format items:

// string s = String.Format("It is now {0:d} at {0:t}", DateTime.Now);
// Console.WriteLine(s);
// // Output similar to: 'It is now 4/10/2015 at 10:04 AM'


// Control spacing
// You can define the width of the string that is inserted into the result string by using syntax such as {0,12}, which inserts a 12-character string. In this case, the string representation of the first object is right-aligned in the 12-character field. (If the string representation of the first object is more than 12 characters in length, though, the preferred field width is ignored, and the entire string is inserted into the result string.)

// The following example defines a 6-character field to hold the string "Year" and some year strings, as well as an 15-character field to hold the string "Population" and some population data. Note that the characters are right-aligned in the field.

// int[] years = { 2013, 2014, 2015 };
//      int[] population = { 1025632, 1105967, 1148203 };
//      var sb = new System.Text.StringBuilder();
//      sb.Append(String.Format("{0,6} {1,15}\n\n", "Year", "Population"));
//      for (int index = 0; index < years.Length; index++)
//         sb.Append(String.Format("{0,6} {1,15:N0}\n", years[index], population[index]));

//      Console.WriteLine(sb);

// Result:
//      Year      Population
//
//      2013       1,025,632
//      2014       1,105,967
//      2015       1,148,203



//Control alignment
// By default, strings are right-aligned within their field if you specify a field width. To left-align strings in a field, you preface the field width with a negative sign, such as {0,-12} to define a 12-character left-aligned field.

// The following example is similar to the previous one, except that it left-aligns both labels and data.

// int[] years = { 2013, 2014, 2015 };
// int[] population = { 1025632, 1105967, 1148203 };
// String s = String.Format("{0,-10} {1,-10}\n\n", "Year", "Population");
// for(int index = 0; index < years.Length; index++)
//    s += String.Format("{0,-10} {1,-10:N0}\n",
//                       years[index], population[index]);
// Console.WriteLine($"\n{s}");
// // Result:
// //    Year       Population
// //
// //    2013       1,025,632
// //    2014       1,105,967
// //    2015       1,148,203


//// Create array of 5-tuples with population data for three U.S. cities, 1940-1950.
// Tuple<string, DateTime, int, DateTime, int>[] cities = 
//     { Tuple.Create("Los Angeles", new DateTime(1940, 1, 1), 1504277, 
//                    new DateTime(1950, 1, 1), 1970358),
//       Tuple.Create("New York", new DateTime(1940, 1, 1), 7454995, 
//                    new DateTime(1950, 1, 1), 7891957),  
//       Tuple.Create("Chicago", new DateTime(1940, 1, 1), 3396808, 
//                    new DateTime(1950, 1, 1), 3620962),  
//       Tuple.Create("Detroit", new DateTime(1940, 1, 1), 1623452, 
//                    new DateTime(1950, 1, 1), 1849568) };

// // Display header
// var header = String.Format("{0,-12}{1,8}{2,12}{1,8}{2,12}{3,14}\n",
//                               "City", "Year", "Population", "Change (%)");
// Console.WriteLine(header);
// foreach (var city in cities) {
//    var output = String.Format("{0,-12}{1,8:yyyy}{2,12:N0}{3,8:yyyy}{4,12:N0}{5,14:P1}",
//                           city.Item1, city.Item2, city.Item3, city.Item4, city.Item5,
//                           (city.Item5 - city.Item3)/ (double)city.Item3);
//    Console.WriteLine(output);
// }
// // The example displays the following output:
// //    City            Year  Population    Year  Population    Change (%)
// //  
// //    Los Angeles     1940   1,504,277    1950   1,970,358        31.0 %
// //    New York        1940   7,454,995    1950   7,891,957         5.9 %
// //    Chicago         1940   3,396,808    1950   3,620,962         6.6 %
// //    Detroit         1940   1,623,452    1950   1,849,568        13.9 %

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         string st2 = "nasr elzanaty khalil";
//         string st3 = "omar Nasr";
//         Console.WriteLine(st2.Clone());
//         Console.WriteLine(st2.Contains('n'));
//         Console.WriteLine(st2.CompareTo(st3));
//         Console.WriteLine(st2.Append(st3));
//     }
// }

