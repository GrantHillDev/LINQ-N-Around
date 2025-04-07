using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using LINQ and then printing with a foreach loop.
             * Push to your GitHub when completed!
             * 
             */
            Console.WriteLine("Here, we'll print out a number of different LINQ related command functions to the console, implementing an array.");
            Console.WriteLine();

            //TODO: Print the Sum of numbers
            Console.WriteLine("The sum of all numbers in the given array:");
            Console.WriteLine();
            var sum = numbers.Sum();//Remember, Sum is a predefined method in C#, even though we're using sum to declare a variable storing data.
            Console.WriteLine(sum);
            Console.WriteLine();
            Console.WriteLine("Or....");
            Console.WriteLine();
            Console.WriteLine(numbers.Sum());
            Console.WriteLine();
            //TODO: Print the Average of numbers
            Console.WriteLine("The average of all numbers in the given array:");
            Console.WriteLine();
            Console.WriteLine(numbers.Average());
            Console.WriteLine();
            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("The order of all numbers in the given array -- ascending:");
            Console.WriteLine();
            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));//Console.WriteLine(numbers.OrderBy());//Here, x represents an index within the array titled numbers. 
            Console.WriteLine();
            foreach (var x in numbers)//this unfortunately doesn't quite account for the index carrying a value of zero....because it only starts at the first index of the array, which in this case has a value of 1, not zero.
            {
                //for (int i = 0; i < 10; i++)
                //{
                //Console.WriteLine(i);
                //}
                //if (x == 0)
                //{
                //    Console.WriteLine("10");
                //}
                Console.WriteLine(x);
            }
            Console.WriteLine();
            //TODO: Order numbers in descending order and print to the console
            Console.WriteLine("The order of all numbers in the given array -- descending:");
            Console.WriteLine();
            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));//Console.WriteLine(numbers.OrderByDescending());//array numbers implementing OrderByDescending method where x lambda x implementing ToList method implementing ForEach x of array numbers print to the console.
            Console.WriteLine();
            Console.WriteLine("Or....");
            Console.WriteLine();
            var orderedbyDescending = numbers.OrderByDescending(x => x);
            foreach (var number in orderedbyDescending)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Printing only numbers in the array which are greater than six:");
            //var numero = 6;
            //if ()
            //{
            Console.WriteLine();
            //}
            numbers.Where(x => x > 6).ToList().ForEach(x => Console.WriteLine(x));//where is what's known as a filter method; it's almost like an abbreviated if statement, in terms of its functionality.
            Console.WriteLine();
            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Printing only the first four numbers of the array.");
            Console.WriteLine();
            var prints4 = numbers.OrderBy(x => x).Take(4);
            foreach (var num in prints4)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            Console.WriteLine("Printing an altered value at array's fourth index.");
            Console.WriteLine();
            numbers.SetValue(38, 4);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            var squares = Enumerable.Range(1, 100).Average(x => x * x);
            Console.WriteLine(squares);
            Console.WriteLine();
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("Printing 'employees' whose first names that start with a c or s, in ascending order.");
            Console.WriteLine();
            //employees.Where(x => x.FirstName[0] == 'C' || x.FirstName[0] == 'S').OrderBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine(x.FullName));
            //employees.Where(x => x.FirstName.StartsWith('C') || x.FirstName.StartsWith('S')).OrderBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine(x.FullName));//.StartsWith is another LINQ method, and happens to be another way in which we can write out the functionality of code described in the line above.
            employees.Where(x => x.FirstName.StartsWith('C') || x.FirstName.StartsWith('S'))//the same exact code as written into the line above, but broken down.
                .OrderBy(x => x.FirstName)//trying to read this as, order by employees' first name 
                .ToList()//to list -- like added to a list?
                .ForEach(x => Console.WriteLine(x.FullName));//for each employee, print to the console the full name of the employee (or, print each employee's full name to the console.
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Printing 'employees' over the age of 26 years.");
            Console.WriteLine();//in the line below, the list has first been filtered (.Where), then ordered (.OrderBy), then ordered again (.ThenBy), then added to the list? Then for each employee, print employee dot full name, the employee dot age.
            employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine($"Full Name: {x.FullName}, Age: {x.Age}"));//beginning to notice that the x variable expressed inside of these LINQ oriented syntaxes represents the initial variable typed into its line of code, which in this case would be employees.
            Console.WriteLine();
            //employees.Where(x => x > 26);//here, there's a variable x attempting to be expressed as something that's greater than an integer, 26, but x is of type employee, which is a string, and a string cannot be directly compared to an integer, let alone in the instance of a conditional.... so, we'd use dot notation to call another variable like age, which contains the same type of integer that 26 consequently is. It almost reads like this; variable employees where employees lambda employees is greater than 26, versus where employees lambda employees' age is greater than 26.
            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Printing 'employees''s sum of experience in years only if their years of experience is less than or equal to a value of 10 and their age is greater than 35.");
            Console.WriteLine();
            //employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).ToList().ForEach(x => Console.WriteLine($"{x. }"));//my first attempt, just couldn't initially think of a way to syntactically print the sum to the console based upon the filter used.
            //employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);//so, in this line of code, we've defined what we wanted to filter and beyond that filter, what it was we wanted to get the sum of as far years of experience.... but we haven't produced a way in which that sum to the console.... but storing the results of this line of code inside of a variable which could then be printed to the console would work.
            var sumOfYOE = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);//even though this variable is inferred, it seems to understand that it's going to yield a value that is the same type as YearsOfExpereince, which is likely why we don't get an error for it.
            Console.WriteLine($"{sumOfYOE}");
            Console.WriteLine();
            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Printing 'employees''s average of experience in years only if their years of experience is less than or equal to a value of 10 and their age is greater than 35.");
            Console.WriteLine();
            double averageOfYOE = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience);
            Console.WriteLine($"{averageOfYOE}");
            Console.WriteLine();
            //TODO: Add an employee to the end of the list without using employees.Add()
            Employee newEmployee = new Employee();
            newEmployee.FirstName = "Derp";
            newEmployee.LastName = "Tacular";
            newEmployee.YearsOfExperience = 2;
            newEmployee.Age = 22;
            Console.WriteLine("New employee list.");
            Console.WriteLine();
            employees.Append(newEmployee).ToList().ForEach(x => Console.WriteLine(x.FullName));//I'm guessing that .Append is another way of adding another variable to something, say a list, as opposed to .Add.
            Console.WriteLine();
            Console.WriteLine("Original employee list.");
            Console.WriteLine();
            foreach (var item in employees)
            {
                Console.WriteLine(item.FullName);
            }
            //Console.ReadLine();
            Console.WriteLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Michael", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
