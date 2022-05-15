using System;

namespace Task003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите номер четверти: ");
            string stra = Console.ReadLine();
            int a = int.Parse(stra);
            if (a == 1){
                Console.Write("Диапозон 1 четверти: x = от 0 до -бесконечности, y = 0 до бесконечности");
            }
            else if (a == 2){
                Console.Write("Диапозон 2 четверти: x = от 0 до бесконечности, y = 0 до бесконечности");
            }
            else if (a == 3){
                Console.Write("Диапозон 3 четверти: x = от 0 до -бесконечности, y = 0 до -бесконечности");
            }
            else if (a == 4){
                Console.Write("Диапозон 4 четверти: x = от 0 до бесконечности, y = 0 до -бесконечности");
            }
            else{Console.Write("Такой четверти не существует");}
            
        }
    }
}
