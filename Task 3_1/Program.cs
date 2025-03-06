using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

namespace Task_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся два числа.
            //Сравнить их и вывести правильный знак «<», «>» или «=».
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            
            if (a > b)
            {
                Console.WriteLine($"{a}>{b}");
            }
            else if (a < b)
            {
                Console.WriteLine($"{a}<{b}");
            }
            else
            {
                Console.WriteLine($"{a}={b}");
            }

            Console.ReadLine();



            
        }
    }
}
