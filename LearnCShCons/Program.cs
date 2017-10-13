using LearnCShCons.learnc.delegateL;
using LearnCShCons.learnc.inheritance_and_polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnCShCons.learnc.interfaceL;
using LearnCShCons.learnc.Sealed;
using LearnCShCons.learnc.Sealed.Static.Abstract;

namespace LearnCShCons
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, I am Zenius, I am glag to see you");
            //Console.ReadLine();
            //Student student = new Student();
            //student.Age = 5;
            //int b=student.Grow(10);
            //Console.WriteLine(b);
            //Console.ReadLine();



            // ====================================================================== test delegate
            //StringHelper helper = new StringHelper();

            //CountDelegate d1 = helper.GetCount;
            //CountDelegate d2 = helper.GetCountSymbolA;
            //string testString = "LAMP";

            //Console.WriteLine("Total number of characters : {0}", TestDelegate(d1, testString));
            //Console.WriteLine("Number of characters A: {0}", TestDelegate(d2, testString));
            //Console.ReadLine();



            //learnc.delegateL.Student student = new learnc.delegateL.Student();
            //student.Moving += student_moving;
            ////student.Move(10);
            //ShowMessege method = Show;
            //student.Move(7, method);

            //Action<string> method = Show;
            //student.Moving = Show;
            //student.Move(7);
            //Console.ReadLine();

            // ====================================================================== test delegate

            //======================================================================= polymorphism
            //BaseShip ship = GetShip(ShipType.TransportShip);
            //string result = ship.Fight();

            //Console.WriteLine(result);
            //Console.ReadLine();
            //======================================================================= polymorphism

            //======================================================================= inheritance

            //BaseShip ship = new TransportShip();
            //string res = ship.ToString();
            //Console.WriteLine(res);
            //Console.ReadLine();

            //явно реализованные интерфейсы
            //TestClass test = new TestClass();

            //Console.WriteLine(test.GetMenu());

            //Window window = test;
            //Console.WriteLine(window.GetMenu());

            //resturant res = test;
            //Console.WriteLine(res.GetMenu());
            //Console.ReadLine();
            //реализация IComparable
            //learnc.interfaceL.Student student1 = new learnc.interfaceL.Student() { Name = "Vasiliy", Age = 20 };
            //learnc.interfaceL.Student student2 = new learnc.interfaceL.Student() { Name = "Petr", Age = 18 };
            //learnc.interfaceL.Student[] students = new learnc.interfaceL.Student[] { student1, student2 };

            //Array.Sort(students);
            //======================================================================= inheritance



            //======================================================================= Sealed.Static.Abstract

           // learnc.Sealed.Static.Abstract.Student student = new learnc.Sealed.Static.Abstract.TestClass(); //создаем иерархию конструкторов


            // learnc.Sealed.Static.Abstract.Student._staticField = 100; //статические члены типа привязаны к самому типу а не к экземпляру типа

            //Singleton singelton = Singleton.Instance;
            //singelton.Count = 100;
            //TestMethod();


            //Console.ReadLine();



            //======================================================================= Sealed.Static.Abstract

        }



        // ====================================================================== test delegate
        static int TestDelegate(CountDelegate method, string testString)
        {
            return method(testString);
        }


        static void Show(string message)
        {
            Console.WriteLine(message);
        }

        static void student_moving(object sender, MovingEventArgs e)
        {
            Console.WriteLine(e.Message);
            
        }

        // ====================================================================== test delegate

        //======================================================================= polymorphism
        public static BaseShip GetShip(ShipType shipype)
        {
            switch (shipype)
            {
                case ShipType.FightShip:
                    return new FightShip();
                case ShipType.TransportShip:
                    return new learnc.inheritance_and_polymorphism.TransportShip();
                default:
                    throw new Exception("Неизвестный тип корабля");
            }

        }
        //======================================================================= polymorphism

        //======================================================================= Singleton
        static void TestMethod()
        {
            Singleton singleton = Singleton.Instance;
            Console.WriteLine(singleton.Count);
        }

        //======================================================================= Singleton
    }
}
