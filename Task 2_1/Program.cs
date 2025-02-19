namespace Task_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Введите c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int t = a;
            a = c;
            c = b;
            b = t;
            Console.WriteLine("Итог: a={0}, b={1}, c={2}", a, b, c);
            Console.ReadKey();
        }
    }
}