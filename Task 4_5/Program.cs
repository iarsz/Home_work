namespace Task_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Запрашивать у пользователя число до тех пор, пока он не введет число из диапазона [20; 60]
            int n;

            do
            {
                Console.Write("Введите число n: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n < 20 || n > 60);

            Console.Write("Программа выполнена");
            Console.ReadKey();
        }
    }
}
