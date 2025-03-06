namespace Task_3_9
{
    internal class Program
    { 
        static void Main(string[] args)
        //Вводится число. Вывести «Да», если оно попадает в диапазон (-∞; -10] Ս [10; +∞), и «Нет» в противном случае

        {
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case int n when a <= -10 || a >= 10:
                    Console.WriteLine("ДА, в диапазоне");
                    break;

                default:
                    Console.WriteLine("НЕТ, вне диапазона");
                    break;
            }
            Console.ReadKey();
        }
    }
}
