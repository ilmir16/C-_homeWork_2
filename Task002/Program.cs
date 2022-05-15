using System;

namespace Task002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1 число: ");
            string stra = Console.ReadLine();
            Console.Write("Введите 2 число: ");
            string strb = Console.ReadLine();
            int a = int.Parse(stra);
            int b = int.Parse(strb);
            if (a == b * b){
                Console.WriteLine($"Число {a} является квадратом числа {b}");
            }
            else{
                 Console.WriteLine($"Число {a} не является квадратом числа {b}");
            }
        }
    }
}
