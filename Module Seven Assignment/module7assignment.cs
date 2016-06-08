using System;
using System.Collections;

namespace ModuleSevenAssignment.GradeClasses
{
public class Program
{
public void Main(string[] args)
{
Student student1 = new Student("Sam", "Dolpho", DateTime.Now, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
student1.AddGrade("A");
student1.AddGrade("B");
student1.AddGrade("C");
student1.AddGrade("D");
student1.AddGrade("F");

Student student2 = new Student("Eric", "Chosen", DateTime.Now, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
student2.AddGrade("F");
student2.AddGrade("A");
student2.AddGrade("A");
student2.AddGrade("D");
student2.AddGrade("A");

Student student3 = new Student("Yorkic", "Namit", DateTime.Now, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
student2.AddGrade("F");
student2.AddGrade("A");
student2.AddGrade("C");
student2.AddGrade("D");
student2.AddGrade("A");

Teacher teacher = new Teacher("Dr.", "Emil", "Shoe", DateTime.Now, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, "Information Technology");
Course course = new Course("Dev204x", "Programming with C#", "Programming", 5, teacher, new ArrayList { student1, student2, student3 });
Degree degree = new Degree("Bachelor", "Computer Science", 400, course);
UProgram program = new UProgram("Information Technology", new ArrayList { "Bachelor", "Masters" }, teacher, degree);
program.Degree.Course.ListStudents();

Console.WriteLine("Press any key to continue...");
Console.ReadKey();
}

#region Classes

public class Course
{
#region Properties

public string Code { get; private set; }

public string Title { get; private set; }

public string Description { get; private set; }

public short CreditHours { get; private set; }

public Teacher Teacher { get; private set; }


public IEnumerable Students { get; private set; }

#endregion Properties

public Course(string code, string title, string description, short creditHours, Teacher teacher, IEnumerable students)
{
Code = code;
Title = title;
Description = description;
CreditHours = creditHours;
Teacher = teacher;
Students = students;
}

#region Students

public void ListStudents()
{
foreach (var student in Students)
{
var castStudent = (Student)student;
Console.WriteLine("{0} {1}", castStudent.FirstName, castStudent.LastName);
}
}

#endregion Students
}

public class Degree
{
#region Properties

public string Level { get; private set; }

public string Major { get; private set; }


public short RequiredCredits { get; private set; }

public Course Course { get; private set; }

#endregion Properties


public Degree(string level, string major, short requiredCredits, Course course)
{
Level = level;
Major = major;
RequiredCredits = requiredCredits;
Course = course;
}
}

public abstract class Person
{
public string FirstName { get; protected set; }
public string LastName { get; protected set; }
public DateTime Birthday { get; protected set; }
public string Address { get; protected set; }
public string Address1 { get; protected set; }
public string City { get; protected set; }
public string State { get; protected set; }
public string Zip { get; protected set; }
public string Country { get; protected set; }
}

public class UProgram
{
#region Properties

public string Name { get; private set; }



public IEnumerable DegreesOffered { get; private set; }

public Teacher DepartmentHead { get; private set; }

public Degree Degree { get; private set; }

#endregion Properties

public UProgram(string name, IEnumerable degreesOffered, Teacher departmentHead, Degree degree)
{
Name = name;
DegreesOffered = degreesOffered;
DepartmentHead = departmentHead;
Degree = degree;
}
}

public class Student : Person
{
private static readonly Random _random = new Random();

#region Static

public static int NumberOfStudents { get; private set; }

#endregion Static

#region Properties

public string Notes { get; private set; }

public Stack Grades { get; private set; }

#endregion Properties

public Student(string fName, string lName, DateTime bDay, string address, string address1,
string city, string state, string zip, string country, string notes)
{
#region Set Inherited Properties

FirstName = fName;
LastName = lName;
Birthday = bDay;
Address = address;
Address1 = address1;
City = city;
State = state;
Zip = zip;
Country = country;

#endregion Set Inherited Properties

Notes = notes;

Grades = new Stack();

NumberOfStudents++;
}

#region Methods

public void AddGrade(string grade)
{
Grades.Push(grade);
}

public bool TakeTest()
{
return (_random.Next(2) % 2) == 0;
}

#endregion Methods
}

public class Teacher : Person
{
#region Properties

public string PreFix { get; private set; }

public string Department { get; private set; }

#endregion Properties

public Teacher(string prefix, string fName, string lName, DateTime bDay, string address, string address1,
string city, string state, string zip, string country, string department)
{
PreFix = prefix;
Department = department;

#region Set Inherited Properties

FirstName = fName;
LastName = lName;
Birthday = bDay;
Address = address;
Address1 = address1;
City = city;
State = state;
Zip = zip;
Country = country;

#endregion Set Inherited Properties
}

public string GiveTest()
{
return string.Format("Teacher {0} gave test.", LastName);
}
}

#endregion Classes
}
}