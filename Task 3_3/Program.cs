namespace Task_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся четыре числа. Вывести большее из них.
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            int n = (a>b && a>c && a>d) ? a :
                    (b>c && b>d) ? b :
                    (c>d) ? c : d;

            Console.WriteLine($"{n}");


            Console.ReadLine();
        }
    }
}
