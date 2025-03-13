namespace Task_4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится n. Определить, является ли оно степенью 2-ки?
            Console.Write("Введите число равное степени 2: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 2;
            int x = 0;

            int n = a%2;

            switch (n)
            {
                case 0:
                    for (int i = 1; i <= 100; i++) // Цикл от 1 до 100
                    {
                        b = b*2;
                        if (a == b)
                        {
                            x = 1;
                            Console.WriteLine("число является степенью двойки");
                        }
                        
                    }
                    if (x == 0)
                    {
                        Console.WriteLine("число не является степенью двойки");
                    }
                    break;

                default:
                    Console.WriteLine("число нечетное");
                    break;
            }
            Console.ReadKey();
        }
    }
}
