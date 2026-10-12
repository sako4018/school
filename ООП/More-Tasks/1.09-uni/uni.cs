using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

class Student
{
    public string Name{get; set;}
    public string Fnumber{get;set;}
    public double Grade{get;set;}
    public int Year{get;set;}

    public Student(string name, string fnumber, double grade, int year)
    {
        Name = name;
        Fnumber = fnumber;
        Grade = grade;
        Year = year;
    }

}
class University
{
    private List<Student> students = new List<Student>();
    public int GetCount()
    {
        return students.Count;
    }
    public Student GetAverageStudent()
    {
        double total = 0.0;
        if (GetCount > 0)
        {
            foreach(Student student in students)
            {
                total = total + student.Grade;
            }
            return total / GetCount();
        }
    }
    public Student GetTopStudent()
    {

        if(students.Count > 0)
        {
            Student topStudent = students[0];
            foreach(Student student in students)
            {
                if (topStudent.Grade < student.Grade)
                {
                    topStudent = student;
                }
            }
            return topStudent;
            
        }
        return null;
    }
    public Student RemoveStudent(string fn)
    {
        foreach(Student student in students)
        {
            if(student.Fnumber == fn)
            {
                student.Name.Remove();
                student.Fnumber.Remove();
                student.Grade.Remove();
                student.Year.Remove();
            }
        }
        return null;
    }
    public Student FindStudent(string fn)
    {
        foreach(Student student in students)
        {
            if(student.Fnumber == fn)
            {
                return student;
            }
        }
        return null;
    }
}