using System;
using System.Reflection.Metadata.Ecma335;

namespace ChildClasses
{

    class Person
    {
        public string Name{get;private set;}
        public Person(string name)
        {
            Name = name;
        }
        public void Display()
        {
            System.Console.WriteLine($"My name is: {Name}");
        }
    }
    class Teacher : Person
    {
        public string School{get;private set;}
        public Teacher(string school,string name):base(name)
        {
            School = school;
        }
        public void DisplaySchool()
        {
            System.Console.WriteLine($"{Name} is teaching in school {School} ");
        }
       
    }
    class Student : Person
    {
        public string Grade{get;private set;}
        public Student(string grade, string name) :base(name)
        {
            Grade = grade;
        }
        public void DisplayGrade()
        {
            System.Console.WriteLine($"{Name} is studyng in {Grade} grade");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("11", "Sarkis");
            student.Display();
            student.DisplayGrade();
            Console.WriteLine(student.Name);
            Teacher teacher = new Teacher("PGEE","Ivan");
            teacher.Display();
            teacher.DisplaySchool();
        }
    }
}
