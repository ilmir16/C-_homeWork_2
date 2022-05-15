using System;

namespace Task004
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number(){
                Console.Write("Введите число: ");
                string str = Console.ReadLine();
                int x = int.Parse(str);
                return x;
            }
            Console.WriteLine("Если вы хотите найти расстояние между двумя точками в пространстве 2D то введите 1, если в 3D то введите 2");
            string str = Console.ReadLine();
            int i = int.Parse(str);
            if (i == 1){
               Console.Write("Для x1 ");int x1 = Number();
               Console.Write("Для y1 ");int y1 = Number();
               Console.Write("Для x2 ");int x2 = Number();
               Console.Write("Для y2 ");int y2 = Number();
               Console.Write($"Расстояние между точками = {Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1))}");
            }
            else if(i == 2){
               Console.Write("Для x1 ");int x1 = Number();
               Console.Write("Для y1 ");int y1 = Number();
               Console.Write("Для z1 ");int z1 = Number();
               Console.Write("Для x2 ");int x2 = Number();
               Console.Write("Для y2 ");int y2 = Number();
               Console.Write("Для z2 ");int z2 = Number();
               Console.Write($"Расстояние между точками = {Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1))}"); 
            }
            else{Console.Write("Вы ввели нету цифру");
        }
    }
}
}
