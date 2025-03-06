namespace Task_2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится длина трубы в метрах. Округлить длину до 0,5. Например, 
            //17,01 -> 17
            //17,099 -> 17
            //17,1 -> 17
            //17,2 -> 17
            //17,3 -> 17,5
            //17,5 -> 17,5
            //17,51 -> 17,5
            //17,6 -> 17,5
            //17,9 -> 18
            //18 -> 18
            //Примечание. Не использовать условные операторы. Разрешено использовать только математические операции и методы библиотеки Math.

            Console.Write("Введите длину трубы: ");
            Double x = Convert.ToDouble(Console.ReadLine());
            
            Double a = Math.Round(x*2)/2;
            Console.WriteLine("Итог: {0}", a);
            Console.ReadKey();
        }
    }
}
