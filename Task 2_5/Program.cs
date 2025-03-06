namespace Task_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится длина трубы в метрах.Округлить длину до целых в большую сторону.Например, 
            //17,0-> 17
            //17,3-> 18
            //17,7-> 18
            Console.Write("Введите длину трубы: ");
            Double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Итог: {0}", Math.Ceiling(x));
            Console.ReadKey();
        }
    }
}
