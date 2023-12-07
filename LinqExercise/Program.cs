using System;
using System.Collections.Generic;
using System.ComponentModel;
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
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine(numbers.Sum());

            //TODO: Print the Average of numbers
            Console.WriteLine(numbers.Average());

            //TODO: Order numbers in ascending order and print to the console
            var numbersAsc = numbers.OrderBy(x => x);
            foreach (var number in numbersAsc)
            {
                Console.WriteLine(number);
            }

            //TODO: Order numbers in descending order and print to the console
            var numbersDesc = numbers.OrderByDescending(x => x);

            foreach (var number in numbersDesc)
            {
                Console.WriteLine(number);
            }

            //TODO: Print to the console only the numbers greater than 6
            var greaterThanSix = numbers.Where(x => x > 6);
            foreach (var number in greaterThanSix)
            {
                Console.WriteLine(number);
            }

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            var onlyFour = numbers.Where(x => x <= 4).OrderBy(x => x);
            foreach (var number in onlyFour)
            {
                Console.WriteLine(number);
            }

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers[4] = 24;
            foreach (var number in numbers.OrderByDescending(x => x))
            {
                Console.WriteLine(number);
            }

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var filteredEmployees = employees.Where(x => x.FirstName.StartsWith('c') || x.FirstName.StartsWith('s')).OrderBy(x => x.FirstName);
            foreach (var employee in filteredEmployees)
            {
                Console.WriteLine(employee.FullName);
            }

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var employeesOver26 = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName);
            foreach (var employee in employeesOver26)
            {
                Console.WriteLine($"{employee.FullName} {employee.Age}");
            }

            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var sum = employees.Where(employee => employee.YearsOfExperience <= 10 && employee.Age > 35).Sum(x => x.YearsOfExperience);
            Console.WriteLine(sum);

            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var average = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience);
            Console.WriteLine(average);

            //TODO: Add an employee to the end of the list without using employees.Add()
            var newList = employees.Concat(new List<Employee> { new Employee { FirstName = "Myles", LastName = "Hill", Age = 24, YearsOfExperience = 5 } } ); 

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
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
