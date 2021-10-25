using System;

namespace Fogli_AN
{
    class Program
    {
        static void Main(string[] args)
        {
            double A0y = 1189, A0x = 841, temp2 = 0;
            string temp;
            Console.Write("Inserire la dimensione di A'n' ");
            temp = Console.ReadLine();
            switch (temp)
            {
                case "A0":
                case "a0":
                    Console.WriteLine($"A0 è {A0y}mm x {A0x}mm");
                    break;
                case "A1":
                case "a1":
                    temp2 = A0y / 2;
                    Console.Write($"A1 è {temp2}mm x ");
                    temp2 = A0x / 2;
                    Console.WriteLine($"{temp2}mm");
                    break;
                case "A2":
                case "a2":
                    temp2 = A0y / 4;
                    Console.Write($"A2 è {temp2}mm x ");
                    temp2 = A0x / 4;
                    Console.WriteLine($"{temp2}mm");
                    break;
                case "A3":
                case "a3":
                    temp2 = A0y / 8;
                    Console.Write($"A3 è {temp2}mm x ");
                    temp2 = A0x / 8;
                    Console.WriteLine($"{temp2}mm");
                    break;
                case "A4":
                case "a4":
                    temp2 = A0y / 16;
                    Console.Write($"A4 è {temp2}mm x ");
                    temp2 = A0x / 16;
                    Console.WriteLine($"{temp2}mm");
                    break;
                case "A5":
                case "a5":
                    temp2 = A0y / 32;
                    Console.Write($"A5 è {temp2}mm x ");
                    temp2 = A0x / 32;
                    Console.WriteLine($"{temp2}mm");
                    break;
                case "A6":
                case "a6":
                    temp2 = A0y / 64;
                    Console.Write($"A6 è {temp2}mm x ");
                    temp2 = A0x / 64;
                    Console.WriteLine($"{temp2}mm");
                    break;
                case "A7":
                case "a7":
                    temp2 = A0y / 128;
                    Console.Write($"A7 è {temp2}mm x ");
                    temp2 = A0x / 128;
                    Console.WriteLine($"{temp2}mm");
                    break;
                case "A8":
                case "a8":
                    temp2 = A0y / 256;
                    Console.Write($"A8 è {temp2}mm x ");
                    temp2 = A0x / 256;
                    Console.WriteLine($"{temp2}mm");
                    break;
                case "A9":
                case "a9":
                    temp2 = A0y / 512;
                    Console.Write($"A9 è {temp2}mm x ");
                    temp2 = A0x / 512;
                    Console.WriteLine($"{temp2}mm");
                    break;
                case "A10":
                case "a10":
                    temp2 = A0y / 1024;
                    Console.Write($"A10 è {temp2}mm x ");
                    temp2 = A0x / 1024;
                    Console.WriteLine($"{temp2}mm");
                    break;
                default:
                    Console.WriteLine($"Il formato di {temp} non è valido");
                    break;
            }
        }
    }
}
