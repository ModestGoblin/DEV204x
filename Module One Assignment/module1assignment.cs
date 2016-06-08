using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleOneAssignment
{
class Program
{
static void Main(string[] args)
{
//Student information:
string first_Name = "Thomas";
string last_Name = "N/A";
DateTime birth_date = new DateTime(5, 10, 1994);
string address_Line1 = "N/A";
string address_Line2 = "N/A";
string city = "N/A";
string state_Province = "Ontario";
string zip_Postal = "N/A";
string country = "Canada";
//Output:
Console.WriteLine("Student information: ");
Console.WriteLine("First Name: " + first_Name);
Console.WriteLine("Last Name: " + last_Name);
Console.WriteLine("Birthdate: " + birth_date.ToShortDateString());
Console.WriteLine("Address Line 1: " + address_Line1);
Console.WriteLine("Address Line 2: " + address_Line2);
Console.WriteLine("City: " + city);
Console.WriteLine("State/Province: " + state_Province);
Console.WriteLine("Zip/Postal: " + zip_Postal);
Console.WriteLine("Country: " + country);
Console.WriteLine(); //Space created


//Professor information:
string pro_first_Name = "N/A";
string pro_last_Name = "N/A";
string[] p_subjects = new string[] { "French", "English" };
//Output:
Console.WriteLine("Professor information: ");
Console.WriteLine("First Name: " + pro_first_Name);
Console.WriteLine("Last Name: " + pro_last_Name);
Console.WriteLine("Subjects Taught: " + string.Join("& ", p_subjects));
Console.WriteLine();

//University Degree:
string ud_fName = "N/A";
string ud_lName = "N/A";
string ud_degree = "Master";
string ud_subject = "Engineering";
int ud_credsReq = 190;
//Output:
Console.WriteLine("University Degree: ");
Console.WriteLine();
Console.WriteLine("First Name: " + ud_fName);
Console.WriteLine("Last Name: " + ud_lName);
Console.WriteLine("Degree: " + ud_degree);
Console.WriteLine("Subject: " + ud_subject);
Console.WriteLine("Credits Required: " + ud_credsReq);
Console.WriteLine();

//University Program:
string up_name = "Computer Science";
string[] up_degrees = new string[] { "Bachelor", "Master", "Ph.D.", "Start-up" };
string up_head = "Master Chief";
//Output:
Console.WriteLine("University Program: ");
Console.WriteLine("Program Name: " + up_name);
Console.WriteLine("Degrees Available: " + string.Join(", ", up_degrees));
Console.WriteLine("Department Head: " + up_head);
Console.WriteLine();

//Course information:
string ci_cName = "Learning Haskell";
string ci_cNum = "CompSci1JC3";
//Output:
Console.WriteLine("Course information: ");
Console.WriteLine("Course Name: " + ci_cName);
Console.WriteLine("Course Number: " + ci_cNum);
Console.WriteLine();
Console.ReadKey();
}
}
}