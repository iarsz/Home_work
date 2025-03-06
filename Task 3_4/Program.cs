namespace Task_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся три разных числа. Вывести медиану – среднее по величине число.
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int n = (b > a && a > c) || (c > a && a > b) ? a :
                    (a > b && b > c) || (c > b && b > a) ? b :
                    c;

            Console.WriteLine($"{n}");


            Console.ReadLine();
        }
    }
}
