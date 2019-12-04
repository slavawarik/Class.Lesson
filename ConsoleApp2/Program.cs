using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
    class Program
    {

        static void Main(string[] args)
        {
            Fruits kiwi = new Fruits("Киви", "Зеленое", "3 месяца");
            kiwi.Info();
            Fruits apple = new Fruits("Яблоко", "Красное", "4 месяца");
            apple.Info();
            Fruits banana = new Fruits("Банан", "Желтый","2 месяца");
            banana.Info();
            Fruits orange = new Fruits("Апельсин","Оранжевый","5 месяцов");
            orange.Info();
            Fruits lemon = new Fruits("Лемон", "Желтый", "1 месяц");
            lemon.Info();
            Console.ReadLine();
        
        }
        
    }
}
