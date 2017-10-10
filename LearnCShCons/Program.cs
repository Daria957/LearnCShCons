using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCShCons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I am Zenius, I am glag to see you");
            Console.ReadLine();
            Student student = new Student();
            student._age = 5;
            Calculate(student);
            Console.WriteLine(student._age);
            Console.ReadLine();
            

        }
        static void Calculate(Student student)
        {
            student._age += 1;
        }
    }
}
