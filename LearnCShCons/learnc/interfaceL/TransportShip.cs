
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LearnCShCons.learnc.interfaceL
{
    class TransportShip : IShip, Idestroy
    {
        public string destruction()
        {
            return "Корабль уничтожен!";
        }

        public string Fight()
        {
            return "Транспортный корабль не может вступать в бой";
        }

        public string Move(int distance)
        {
            double time = (double)distance / 1000;
            return string.Format("Пройдено километров: {0}, за время: {1}", distance, time);

        }
    }
}