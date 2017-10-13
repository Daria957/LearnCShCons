using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCShCons.learnc.Sealed.Static.Abstract
{
    public  class Student
    {


        public static int _staticField;

        public Student()
        {
            Console.WriteLine("Вызов экземплярного конструктора Студент");
        }

        //public int _instanceField;
        //public void SetValue(int value)
        //{
        //    this._instanceField = value; //this - ссылка, которая указывает на текущий экземпляр класса 
        //    _staticField = value;
        //}
        //public static void SetValueStatic(int Value)
        //{


        //}

    }
    public class TestClass:Student
    {
        static TestClass()
        {
            Console.WriteLine("Вызов статического конструктора ТестКласс");

        }
        public TestClass()
        {
            Console.WriteLine("Вызов экземплярного конструтора ТестКласс");
        }

    } 
    
}
