using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircus_Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string go;
            
            do
            {
                
                Console.WriteLine("Learn your squares and cubes!");
                Console.Write("Enter an integer:");
                int number = int.Parse(Console.ReadLine());

                const string format = "|{0,6} | {1,8} | {2,4}";
                Console.WriteLine(string.Format(format, "Number", "Squared", "Cubed"));
                Console.WriteLine(string.Format(format, "======", "=======", "======"));
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(string.Format(format, i, i*i, i*i*i));
                    
                }
                Console.WriteLine("Continue? (y/n)");
                go = Console.ReadLine();
            } while (go.ToLower() == "yes" || go.ToLower() == "y");
        }
    }
}
