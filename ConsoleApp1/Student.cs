using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
         int RollNo;
       internal  string Name;
      internal    void acc(int RollNo,string  name)
        {
            this.RollNo = RollNo;
        this.Name=name;
        }

      internal  void dis ()
        {
            Console.WriteLine($"{RollNo} := {Name}");
        }

        public static void Main()
        {
            Teacher s=new Teacher();
            s.acc(56);
            s.dis();
        }
    }


}
