namespace Task_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 4-х значное число: ");
            int x = Convert.ToInt16(Console.ReadLine());


            int a1 = x/1000;
            int a2 = (x/100)%10;
            int a3 = (x/10)%10;
            int a4 = x%10;

            Console.WriteLine("Итог: {0}{1}{2}{3}", a1, a4, a3, a2);
            Console.ReadKey();
        }
    }
}
