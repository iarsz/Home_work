namespace Task_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину трубы: ");
            Double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Итог: {0}", Math.Ceiling(x));
            Console.ReadKey();
        }
    }
}
