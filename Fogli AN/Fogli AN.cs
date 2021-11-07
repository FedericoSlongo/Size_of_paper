using System;

namespace Fogli_AN
{
    class Program
    {
        static void Main(string[] args)
        {
            double A0y = 1189, A0x = 841, A = 0, Atemp = 0;
            Console.Write("Inserire la dimensione di A");
            A = Convert.ToDouble(Console.ReadLine());
            switch (A)
            {
                case 0:
                    Console.WriteLine($"A{A} {A0y} mm * {A0x} mm");
                    break;
                case > 40:
                    Console.WriteLine("Il valore è troppo basso");
                    break;
                default:
                    Atemp = Math.Pow(1.4142, A);
                    Console.WriteLine($"A{A} {(A0y / Atemp):000.000} mm * {(A0x / Atemp):000.000} mm");
                    break;
            }
        }
    }
}
