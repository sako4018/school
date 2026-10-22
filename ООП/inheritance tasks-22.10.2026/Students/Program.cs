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

        public Person(string name, string egn, int yearOld)
        {
            Name = name;
            EGN = egn;
            YearOld = yearOld;
        }
        public Person() : this("NoName","NoLastname",0)
        {
            
        }
    }
    class Student : Person
    {
        List<double> grades = new List<double>();
        List<string> subjects = new List<string>();

        public Student(string name, string egn, int age) : base(name,egn,age)
        {

        }
        public Student():base()
        {
            
        }

        public void AddGrade(string subject, double grade)
        {
            if(grades.Count() == subjects.Count())
            {
                if(subject != null)
                {
                    subjects.Add(subject);
                }
                if (grade >= 2 && grade <= 6)
                {
                    grades.Add(grade);
                }
            }
        }
    }
    class Employee : Person
    {
        private decimal _salary;
        public decimal Salary{get;private set;}
        public Employee(decimal salary, string name, string egn, int age) : base(name,egn,age)
        {
            Salary = salary;
        }
        public Employee() :base()
        {
            
        }
    }
    class Staff : Employee
    {
        private string _position;
        public string Position{get;private set;}

        public Staff(string position) : base(salary)
        {
            Position = position;
        }
        public Staff() :base()
        {
            
        }
    }
    class Program
    {
        public void ReadPersonData()
        {
            
        }
        public void PrintPersonData()
        {
            
        }
        public void ReadStudentData()
        {
            
        }
        public void PrintStudentData()
        {
            
        }
        public void ReadEmployeeData()
        {
            
        }
        public void PrintEmployeeData()
        {
            
        }
        public void ReadStaffData()
        {
            
        }
        public void PrintStaffData()
        {
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
