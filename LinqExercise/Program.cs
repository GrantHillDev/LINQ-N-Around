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
            foreach (var x in numbers)//this unfortunately doesn't quite account for the index carrying a value of zero....becaue it only starts at the first index of the array, which in this case has a value of 1, not zero.
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
            Console.WriteLine("Printing only numbers in the array whic are greater than six:");
            //var numero = 6;
            //if ()
            //{
            Console.WriteLine();
            //}
            numbers.Where(x => x > 6).ToList().ForEach(x => Console.WriteLine(x));//where is what's known as a filter method; it's almost like an abbreviated if statement, in terms of its functionality.
            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine();
            //TODO: Change the value at index 4 to your age, then print the numbers in descending order

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            //TODO: Add an employee to the end of the list without using employees.Add()


            Console.WriteLine();

            Console.ReadLine();
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
