
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LearnCShCons.learnc.delegateL
{
    public delegate int CountDelegate(string message);
      public  class StringHelper
    {
        public int GetCount(String inputString)
        {
            return inputString.Length;
        }
        public int GetCountSymbolA(string inputString)
        {
            return inputString.Count(c => c == 'A');
        }
        //public int GetCountSymbol(string inputString, char symbol)      //    ========= Не входит т.к. два входных параметра
        //{
        //    return inputString.Count(c => c == symbol);
        //}
    }
}