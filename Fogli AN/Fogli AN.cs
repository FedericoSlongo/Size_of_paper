using System;

namespace Fogli_AN
{
    class Program
    {
        static void Main(string[] args)
        {
            double A0y = 1189, A0x = 841, A = 0, temp2 = 0;
            Console.Write("Inserire la dimensione di A");
            A = Convert.ToDouble(Console.ReadLine());
            switch (A)
            {
                case 0:
                    Console.WriteLine($"A{A} {A0y} mm * {A0x} mm");
                    break;
                default:
                    temp2 = Math.Pow(1.4142, A);
                    Console.WriteLine($"A{A} {(A0y / temp2):000.00} mm * {(A0x / temp2):000.00} mm");
                    break;
            }
        }
    }
}
