namespace Task_3_11
{
    internal class Program
    {
        static void Main(string[] args)
        //Можно ли на прямоугольном участке застройки размером a * b метров разместить
        //два дома размером в плане p * q и r * s метров? Дома можно располагать только
        //параллельно сторонам участка. Дома могу стоять «вплотную» друг к другу.
        {
            Console.WriteLine("Введите сторону участка a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону участка b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону дома #1, p");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону дома #1, q");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону дома #2, r");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону дома #2, s");
            int s = Convert.ToInt32(Console.ReadLine());

            int x1 = p+r;
            int x2 = q+s;
            int x3 = p+s;
            int x4 = q+r;

            if ((x1 <= a && q <= b && s <= b) ||
                (x2 <= a && p <= b && r <= b) ||
                (x3 <= a && q <= b && r <= b) ||
                (x4 <= a && p <= b && s <= b) ||

                (x1 <= b && q <= a && s <= a) ||
                (x2 <= b && p <= a && r <= a) ||
                (x3 <= b && q <= a && r <= a) ||
                (x4 <= b && p <= a && s <= a) ||

                (x1 <= b && x2 <= a) ||
                (x2 <= b && x1 <= a) ||
                (x3 <= b && x4 <= a) ||
                (x4 <= b && x3 <= a))


            {
                Console.WriteLine("Дома войдут");
            }
             
            else
            { 
                Console.WriteLine("Дома не войдут");
            }
                
            Console.ReadKey();
        }
    }
}
