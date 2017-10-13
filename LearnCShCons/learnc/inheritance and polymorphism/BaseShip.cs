
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LearnCShCons.learnc.inheritance_and_polymorphism
{
    public class BaseShip //: System.Object - если явно не указано наследование, класс наследуется от System.Object
    {
        public BaseShip() {
            //Console.WriteLine("Конструктор родительского класса:");
        }

        private int _counter;
        protected int _speed;
        //=======================================inheritance
        //public string Move(int distance)
        //{
        //    _counter++;
        //    string result = string.Format("Пройдено километров: {0}", distance);
        //    return result;
        //}
        //=======================================inheritance

        //=======================================polymorphism
        //public virtual string Move(int distance)
        //{
        //    //string result = string.Format("Пройдено километров: {0}", distance);
        //    //return result;
        //    double time = (double)distance / 1000;
        //    return string.Format("Пройдено километров:{0} за время: {1}", distance, time);

        //}

        public override string ToString()
        {
            return "Транспортный корабль";
        }

        


        public virtual string Move(int distance)
        {
            string result = string.Format("Пройдено километров: {0}", distance);
            return result;
        }
        
        public virtual string Fight()
        {
            return "Произошел бой";
        }
        //=======================================polymorphism
    }
    //public class TransportShip : BaseShip
    //{

    //    public TransportShip() : base(0) // :base()
    //    {
    //        Console.WriteLine("Конструктор базового класса");
    //    }
    //    public override string ToString()
    //    {
    //        return "Транспортный корабль";
    //    }

    //    //=======================================inheritance
    //    //public void Start()
    //    //{

    //    //}
    //    //=======================================inheritance
    //    public override string Move(int distance)
    //    {
    //        //string result = string.Format("Траспортный корабль преодолел километров: {0}", distance);
    //        string result = base.Move(distance);
    //        result += string.Format(" \n Траспортный корабль преодолел километров: {0}", distance);
    //        return result;
    //    }
        


    //}
}