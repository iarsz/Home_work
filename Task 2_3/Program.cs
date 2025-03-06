namespace Task_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Длина отрезка задана в дюймах (1 дюйм = 2,54 см). Перевести
            //значение длины в метрическую систему, то есть выразить ее в метрах,
            //сантиметрах и миллиметрах. Например, 21 дюйм = 0 м 53 см 3,4 мм
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
