using System;
namespace Wananchai
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int iterator = 0; iterator < 3; iterator++)
            {
                Console.WriteLine("Outer Loop:" + iterator);//Execute 3 time

                for (int _iterator = 0; _iterator < 2; _iterator++)
                {
                    Console.WriteLine("Inner Loop:" + iterator);//Excute 2 time

                }


            }

            string[] brandTV = { "LG", "SONY", "SAMSUNG", "TCL", "JVC" };

            foreach (string television in brandTV)
            {
                Console.WriteLine("Brand" + television);
            }
        }
    }
}