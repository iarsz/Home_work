namespace Task_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите градус угла: ");
            double _grad = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите минуту угла: ");
            double _min = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите cекунду угла: ");
            double _sec = Convert.ToDouble(Console.ReadLine());
            

            _min = _min/60;
            _sec = _sec/60/60;
            double ugolGrad = _grad+_min+_sec;
            double ugolRad = ugolGrad*double.Pi/180;
            ugolRad=Math.Round(ugolRad, 4);
            Console.WriteLine("Радиус угла: {0}", ugolRad);
            Console.ReadKey();
        }
    }
}
