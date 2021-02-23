using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string result = "";
            while (true)
            {
                Random rnd = new Random();
                for (int i = 0; i < 78; i++)
                {              
                    int value = rnd.Next(0, 100);
                    if (value < 1.5+30)
                    {
                        result += 1;
                    }
                    else
                    {
                        result += 0;
                    }
                }
                Console.WriteLine(result);

                Thread.Sleep(70);
                result = "";
            }
        }
    }
}
