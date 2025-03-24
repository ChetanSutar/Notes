using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Teacher : Student
    {
        int marks;


     internal   void acc(int marks)
        {
            this.marks = marks;
           
        }

      internal  void dis()
        {
            Console.WriteLine($" {marks} {Name}");
        }

    }
}
