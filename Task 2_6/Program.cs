namespace Task_2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину трубы: ");
            Double x = Convert.ToDouble(Console.ReadLine());
            
            Double a = Math.Round(x*2)/2;
            Console.WriteLine("Итог: {0}", a);
            Console.ReadKey();
        }
    }
}
