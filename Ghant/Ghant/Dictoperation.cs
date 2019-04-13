using System;
using System.Collections.Generic;
using System.Linq;

namespace Ghant
{
    public class Dictoperation
    {
        public Dictoperation(){}

        public Dictionary<string, double[]> DictInput(Dictionary<string, double[]> dict)
        {
            Error error = new Error();

            int counter = 1;
            double[] array;

            while (true)
            {
                Console.WriteLine($"Enter info about {counter} event:");

                Console.Write("Enter event name:");
                string name = error.GetString();

                if (name.ToLower() == "exit")
                {
                    break;
                }

                array = new double[2];

                Console.Write("\nEnter priority:");
                array[0] = error.GetDouble();

                Console.Write("\nEnter process run time:");
                array[1] = error.GetDouble();

                dict.Add(name, array);

                counter++;
            }

            return dict;
        }

        public void DictPrint(Dictionary<string, double[]> dict)
        {
            Console.WriteLine("\nDictionary:");

            foreach (string s in dict.Keys)
            {
                Console.WriteLine(" Name: " + s + " Priority: " + dict[s][0] + " Time: " + dict[s][1]);
            }
            Console.WriteLine();
        }

        public Dictionary<string, double[]> DictSort(Dictionary<string, double[]> dict)
        {
            Dictionary<string, double[]> neweventDict = new Dictionary<string, double[]>();

            foreach (KeyValuePair<string, double[]> d in dict.OrderBy(key => key.Value[0]))
            {
                Console.WriteLine("{0} - {1} - {2}", d.Key, d.Value[0], d.Value[1]);

                neweventDict.Add(d.Key, d.Value);
            }
            return neweventDict;
        }

        public void GhantPrint (Dictionary<string, double[]> dict)
        {
            int counter = 1;

            foreach (string s in dict.Keys)
            {
                //Console.Write("Priority: {0}  ", counter);

                counter++;

                for(int i = 0; i < dict[s][1]; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                for (int i = 0; i < dict[s][1]; i++)
                {
                    Console.Write(" ");
                }

            }
        }
    } 
}
