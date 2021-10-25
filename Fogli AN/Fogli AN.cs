using System;

namespace Fogli_AN
{
    class Program
    {
        static void Main(string[] args)
        {
                double A0y = 1189, A0x = 841, temp = 0, temp2 = 0, temp3 = 0;
                Console.Write("Inserire la dimensione di A");
                temp = Convert.ToDouble(Console.ReadLine());
                switch (temp)
                {
                    case 0:
                        Console.WriteLine($"A{temp} {A0y} mm * {A0x} mm");
                        break;
                    default:
                        temp2 = Math.Pow(1.4142, temp);
                        Console.Write($"A{temp} {A0y / temp2} mm * {A0x / temp2} mm");
                        break;
                }
        }
    }
}
