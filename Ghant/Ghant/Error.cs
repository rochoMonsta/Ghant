using System;
namespace Ghant
{
    public class Error
    {
        public Error()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public double GetDouble()
        {
            double number = 0;
            try
            {

                number = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
            return number;
        }

        public string GetString()
        {
            string str = "";
            try
            {
                str = Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }

            return str;
        }
    }
}
