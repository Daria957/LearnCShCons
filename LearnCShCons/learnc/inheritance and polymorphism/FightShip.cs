
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LearnCShCons.learnc.inheritance_and_polymorphism
{
    class FightShip : BaseShip
    {
        public override string ToString()
        {
            return "Боевой корабль";
        }

        public override string Move(int distance)
        {
            double time = (double)distance / 1000;
            return string.Format("Боевой корабдь прошел: {0} за время {1}", distance, time);
        }

        public override string Fight()
        {
            return "Боевой корабль ведет бой";
        }

    }
}