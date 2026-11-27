using System;
using System.Collections.Generic;

namespace Task_03_08
{
    interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
        string Role { get; set; }
    }

    interface IEmployee
    {
        int ID { get; set; }
        double Salary { get; set; }
        string Experience { get; set; }
    }

    // Общ клас за служителите, за да не се повтаря кодът три пъти.
    // Реализира и двата интерфейса. Възрастта и заплатата са неотрицателни.
    class Employee : IPerson, IEmployee
    {
        private int age;
        private double salary;

        public string Name { get; set; }
        public string Role { get; set; }
        public int ID { get; set; }
        public string Experience { get; set; }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Възрастта не може да е отрицателна.");
                }
                age = value;
            }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Заплатата не може да е отрицателна.");
                }
                salary = value;
            }
        }

        public Employee(string name, int age, string role, int id, double salary, string experience)
        {
            Name = name;
            Age = age;
            Role = role;
            ID = id;
            Salary = salary;
            Experience = experience;
        }
    }

    class HeadTeacher : Employee
    {
        public HeadTeacher(string name, int age, int id, double salary, string experience)
            : base(name, age, "Head teacher", id, salary, experience)
        {
        }
    }

    class Teacher : Employee
    {
        public Teacher(string name, int age, int id, double salary, string experience)
            : base(name, age, "Teacher", id, salary, experience)
        {
        }
    }

    class Staff : Employee
    {
        public Staff(string name, int age, int id, double salary, string experience)
            : base(name, age, "Staff", id, salary, experience)
        {
        }
    }

    // Студентът е само IPerson, няма ID и заплата
    class Student : IPerson
    {
        private int age;
        private double grade;

        public string Name { get; set; }
        public string Role { get; set; }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Възрастта не може да е отрицателна.");
                }
                age = value;
            }
        }

        public double Grade
        {
            get { return grade; }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentException("Оценката трябва да е от 2 до 6.");
                }
                grade = value;
            }
        }

        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Role = "Student";
            Grade = grade;
        }
    }

    // Собствена колекция
    class Persons<T>
    {
        private List<T> list = new List<T>();

        public int Count
        {
            get { return list.Count; }
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public T this[int index]
        {
            get { return list[index]; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Persons<IPerson> persons = new Persons<IPerson>();

            persons.Add(new HeadTeacher("Петър Иванов Георгиев", 50, 1, 2500, "has experience"));
            persons.Add(new Teacher("Стоян Илиев Кирилов", 34, 2, 1500, "has experience"));
            persons.Add(new Staff("Димитър Стоянов Иванов", 44, 3, 1000, "no experience"));
            persons.Add(new Student("Илия Йорданов Димитров", 20, 6.00));

            int employees = 0;
            int students = 0;

            for (int i = 0; i < persons.Count; i++)
            {
                IPerson person = persons[i];

                // Общите данни
                Console.Write(person.Name + "; " + person.Age + " г.; " + person.Role);

                // Данни само за служителите
                if (person is IEmployee employee)
                {
                    Console.Write("; ID " + employee.ID + "; " + employee.Salary + " лв.; " + employee.Experience);
                    employees++;
                }

                // Данни само за студента
                if (person is Student student)
                {
                    Console.Write("; Grade " + student.Grade.ToString("F2") + "; no experience");
                    students++;
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Общ брой: " + persons.Count);
            Console.WriteLine("Служители: " + employees);
            Console.WriteLine("Студенти: " + students);
        }
    }
}
