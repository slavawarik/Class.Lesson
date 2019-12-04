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
            kiwi.FruitsInfo();
            Fruits apple = new Fruits("Яблоко", "Красное", "4 месяца");
            apple.FruitsInfo();
            Fruits banana = new Fruits("Банан", "Желтый","2 месяца");
            banana.FruitsInfo();
            Fruits orange = new Fruits("Апельсин","Оранжевый","5 месяцов");
            orange.FruitsInfo();
            Fruits lemon = new Fruits("Лемон", "Желтый", "1 месяц");
            lemon.FruitsInfo();
            Products eggs = new Products("Яйца", 45, 2, 40);
            eggs.ProductsInfo();
            Products tomato = new Products("Помидор", 35, 4, 80);
            tomato.ProductsInfo();
            Console.ReadLine();
        }
    }
}
