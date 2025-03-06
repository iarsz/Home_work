namespace Task_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся три числа. Вывести большее их них.
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());


            if (a > b)
            {
                if (a>c)
                {
                    Console.WriteLine($"{a}");
                }
                else
                { Console.WriteLine($"{c}"); }
            }
            else if (b>c)
            {
                Console.WriteLine($"{b}");
            }
            else
            {
                Console.WriteLine($"{c}");
            }

            Console.ReadLine();
        }
    }
}
