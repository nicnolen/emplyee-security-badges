﻿// See https://aka.ms/new-console-template for more information
//* using imports a common namespace (naming shortcut). Without this naming shortcut, you would have to write System before every Console you use
//? System contains a collection of commonly used methods, data types and data structures
using System;
//? Contains things like lists and dictionaries
using System.Collections.Generic;

//* Namespace organizes and provides a level of seperation in the code. It is followed by the name of the app
namespace CatWorx.BadgeMaker
{
  class Program
  {
    //* Main method serves as the entry point to the application
    //? static means that the scope of the method is at the class level and can be invoked without creating a new class instance (object). Void means there will be no explicit return type
    static void Main(string[] args) {
      List<Employee> employees;

       Console.WriteLine("Would you like to enter employee information? (y/n): ");
            string response1 = Console.ReadLine();
            if (response1 == "y" || response1 == "yes" || response1 == "Yes") {
              employees = PeopleFetcher.GetEmployees();
              Util.PrintEmployees(employees);
              // print employees to CSV file
              Util.MakeCSV(employees);
              // make badges for employees
              Util.MakeBadges(employees);
            }

        Console.WriteLine("Would you like to fetch employee data from the API? (y/n): ");
        string response2 = Console.ReadLine();
        if (response2 == "y" || response2 == "yes" || response2 == "Yes")
        {
          // employees = PeopleFetcher.GetEmployees();
          employees = PeopleFetcher.GetFromApi();
          // print employees to CSV file
          Util.MakeCSV(employees);
          // make badges for employees
          Util.MakeBadges(employees);
        }
    }

  }
}



