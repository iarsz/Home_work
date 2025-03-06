namespace Task_3_10
{
    internal class Program
    {
        static void Main(string[] args)
        //Застройщик построил n домов. Вывести фразу «Мы построили n домов»,
        //обеспечив правильное согласование числа со словом «дом», например:
        //20 — «Мы построили 20 домов»,
        //32 — «Мы построили 32 дома», 41 — «Мы построили 41 дом».

        {
            int a = Convert.ToInt32(Console.ReadLine());
            int n1 = a % 10;
            int n2 = a % 100;

            switch (a)
            {
                case int x when n1 == 1 && a != 11:
                    Console.WriteLine($"Мы построили {a} дом");
                    break;

                case int x when (n1 >= 2 && n1 <= 4) && (n2 < 12 || n2 > 14):
                    Console.WriteLine($"Мы построили {a} дома");
                    break;

                default:
                    Console.WriteLine($"Мы построили {a} домов");
                    break;
            }
            Console.ReadKey();
        }
    }
}
