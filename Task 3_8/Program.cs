namespace Task_3_8
{
    internal class Program
    {
        static void Main(string[] args)
        //Вводится число. Вывести «Да», если оно попадает в диапазон [-10,10], и «Нет» в противном случае

        {
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case int n when a < -10:
                    Console.WriteLine("НЕТ, вне диапазона");
                    break;

                case int n when a > 10:
                    Console.WriteLine("НЕТ, вне диапазона");
                    break;

                default:
                    Console.WriteLine("ДА, в диапазоне");
                    break;
            }
            Console.ReadKey();
        }
    }
}
