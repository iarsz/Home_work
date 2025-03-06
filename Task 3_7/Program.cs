namespace Task_3_7
{
    internal class Program
    {
        static void Main(string[] args)
        //Вводится число. Вывести «Да», если оно двухзначное, и «Нет» в противном случае.

        {
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case int n when a < 10:
                    Console.WriteLine("НЕТ, не двухзначное");
                    break;

                case int n when a > 99:
                    Console.WriteLine("НЕТ, не двухзначное");
                    break;

                default:
                    Console.WriteLine("ДА, двухзначное");
                    break;
            }
            Console.ReadKey();
        }
    }
}
