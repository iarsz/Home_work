namespace Task_3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится число. Вывести «Да», если оно оканчивается на 0, и «Нет» в противном случае.
            int a = Convert.ToInt32(Console.ReadLine());
            
            int n = a%10; ;
            
            switch (n)
            {
                case 0:
                    Console.WriteLine("ДА");
                    break;
                
                default:
                    Console.WriteLine("НЕТ");
                    break;
            }
            Console.ReadKey();
        }
    }
}
