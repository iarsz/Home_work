namespace Task_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину отрезка в дюймах: ");
            double otrDyuym = Convert.ToDouble(Console.ReadLine());
            double dOtrMetr = otrDyuym * 254;
            uint iOtrMetr = Convert.ToUInt32(dOtrMetr);
            uint metr = iOtrMetr/10000;
            uint sm1 = (iOtrMetr/1000)%10;
            uint sm2 = (iOtrMetr/100)%10;
            uint mm1 = (iOtrMetr/10)%10;
            uint mm2 = iOtrMetr%10;
            
            Console.WriteLine("{0}м, {1}{2}см, {3},{4}мм", metr, sm1, sm2, mm1, mm2);
            Console.ReadKey();
        }
    }
}
