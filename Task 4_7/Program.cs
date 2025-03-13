namespace Task_4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится n. Определить количество цифр в числе
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int i = a;
            int x = 0;

            do
            {
                x++;
                i = i/10;
            }

            while (i != 0);
            Console.WriteLine($"Количество цифр в числе {a}: {x}");
            Console.ReadKey();

        }

    }
}
