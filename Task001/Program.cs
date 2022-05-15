using System;

namespace Task001
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Введите число обозначающее день: ");
            string str = Console.ReadLine();
            int a = int.Parse(str);
            if (a == 4 || a == 5){
                Console.WriteLine("Данный номер дня является выходным!");
            }
            else
                Console.WriteLine("Данный номер дня не является выходным!");
        }
    }
}
