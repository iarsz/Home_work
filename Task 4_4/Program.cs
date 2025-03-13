namespace Task_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся целые числа a>0, b<0. Найти a^b. Не использовать класс Math
            Console.Write("Введите число a: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            double x = a;

            b = b * (-1);

            for (int i = 1; i < b; i++)
            {

                x = x * a;

            }
            Console.Write($"{1/x}");
            Console.ReadKey();
        }
    }
}
