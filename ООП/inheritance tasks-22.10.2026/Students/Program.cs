using System;
using System.Transactions;

namespace Students
{
    class Person
    {
        private string _name;
        private string _egn;
        private int _yearOld;

        public string Name{get;private set;}
        public string EGN{get;private set;}
        public int YearOld{get;private set;}

        public Person(string name, string egn, int year)
        {
            
        }
        public Person() : this("NoName","NoLastname",0)
        {
            
        }
    }
    class Student : Person
    {
        List<double> grades = new List<double>();
        List<string> subject = new List<string>();
    }
    class Employee
    {
        private decimal _salary;
        public decimal Salary{get;private set;}
    }
    class Staff
    {
        private string _position;
        public string Position{get;private set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
