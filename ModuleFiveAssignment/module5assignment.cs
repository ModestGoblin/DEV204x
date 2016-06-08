using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFiveAssignment
{
class UProgram
{
public UProgram(string name)
{
this.Name = name;
}

public string Name { get; set; }
public Degree Degree { get; set; }
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFiveAssignment
{
class Teacher
{
public Teacher(
string firstName,
string lastName,
DateTime birthdate
)
{
this.FirstName = firstName;
this.LastName = lastName;
this.Birthdate = birthdate;
}

public string FirstName { get; set; }
public string LastName { get; set; }
public DateTime Birthdate { get; set; }
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFiveAssignment
{
class Student
{
public Student(
string firstName,
string lastName,
DateTime birthdate,
string addressLine1,
string addressLine2,
string city,
string Province,
string zipCode,
string country
)
{
this.FirstName = firstName;
this.LastName = lastName;
this.Birthdate = birthdate;
this.AddressLine1 = addressLine1;
this.AddressLine2 = addressLine2;
this.City = city;
this.StateOrProvince = Province;
this.Zip = zipCode;
this.Country = country;
}

public string FirstName { get; set; }
public string LastName { get; set; }
public DateTime Birthdate { get; set; }
public string AddressLine1 { get; set; }
public string AddressLine2 { get; set; }
public string City { get; set; }
public string StateOrProvince { get; set; }
public string Zip { get; set; }
public string Country { get; set; }
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFiveAssignment
{
class Degree
{
public Degree(string name)
{
this.Name = name;
}

public string Name { get; set; }
public Course Course { get; set; }
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFiveAssignment
{
class Course
{
public Course(string name)
{
this.Name = name;
this._students = new Student[3];
this._teachers = new Teacher[3];
}

public string Name { get; set; }
public Student[] Students { get { return _students; } }
public Teacher[] Teachers { get { return _teachers; } }

private Student[] _students;
private Teacher[] _teachers;
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFiveAssignment
{
class Program
{
static void Main(string[] args)
{

Student student1 = new Student(
"John", "Smith", new DateTime(2020, 1, 1),
"Street 11", "appt. 69", "Fort Myers", "Florida", "03048", "USA"
);

Student student2 = new Student(
"John", "Smith", new DateTime(2020, 1, 1),
"Street 11", "appt. 69", "Fort Myers", "Florida", "03048", "USA"
);
Student student3 = new Student(
"John", "Smith", new DateTime(2020, 1, 1),
"Street 11", "appt. 69", "Fort Myers", "Florida", "03048", "USA"
);

Course course = new Course("Programming with C#");

course.Students[0] = student1;
course.Students[1] = student2;
course.Students[2] = student3;

Teacher teacher1 = new Teacher("Oleksandr", "Polyakov", new DateTime(1976, 05, 11));

course.Teachers[0] = teacher1;

Degree bachelorDegree = new Degree("Bachelor of Science");

bachelorDegree.Course = course;

UProgram program = new UProgram("Information Technology");

program.Degree = bachelorDegree;

Console.WriteLine("\nThe {0} program contains the {1} degree.", program.Name, program.Degree.Name);
Console.WriteLine("\nThe {0} degree contains the course {1}.", bachelorDegree.Name, bachelorDegree.Course.Name);
Console.WriteLine("\nThe {0} course contains {1} student(s).", course.Name, course.Students.Length);

Console.Read();
}
}
}