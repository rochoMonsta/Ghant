using System;
using System.Collections.Generic;

namespace Ghant
{
    class Program
    {
        static void Main(string[] args)
        {
            Error error = new Error();
            Dictoperation dictoperation = new Dictoperation();

            Dictionary<string, double[]> eventDict = new Dictionary<string, double[]>();
            Dictionary<string, double[]> neweventDict = new Dictionary<string, double[]>();

            dictoperation.DictInput(eventDict);
            Console.Clear();
            dictoperation.DictPrint(eventDict);
            Console.Clear();
            neweventDict = dictoperation.DictSort(eventDict);
            Console.ReadKey();
            Console.Clear();
            dictoperation.DictPrint(neweventDict);
            dictoperation.GhantPrint(neweventDict);
        }
    }
}
