using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTwoAssignment
{
class Program
{
static void Main()
{
Print1();
Console.ReadLine();
}
//working
static void Print1()
{
for (var i = 0; i < 8; i++)
for (var j = 0; j < 4; j++)
Console.Write((i % 2 == 0 ? "XO" : "OX")
+ (j == 3 ? "\n" : ""));
}
//one
static void Print2()
{
for (var i = 0; i < 8; i++)
for (var j = 0; j < 1; j++)
Console.WriteLine(i % 2 == 0 ? "XOXOXOXO" : "OXOXOXOX");
}


}
}