namespace Task_3_6
{
    internal class Program
    {
        static void Main(string[] args)
        //Вводится число. Вывести «Да», если оно четное, и «Нет» в противном случае.
        {
            int a = Convert.ToInt32(Console.ReadLine());
            
            int n = a%2; 

            switch (n)
            {
                case 0:
                    Console.WriteLine("ДА, четное");
                    break;

                default:
                    Console.WriteLine("НЕТ, нечетное");
                    break;
            }
            Console.ReadKey();
        }
    }
}
