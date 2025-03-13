namespace Task_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится натуральное число n. Найти 1 + 1/2 + 1/3 + … + 1/n
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double f = 0;
            for (int i = 1; i <= n; i++)
            {

                f = f + 1.0 / i;

            }
            Console.Write($"{f}");
            Console.ReadKey();
        }
    }
}
