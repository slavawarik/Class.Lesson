using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Products
    {
        public string name;
        public int price;
        public int storage_life;
        public int weight;

        public void ProductsInfo()
        {
            Console.WriteLine($"Название: {name} Стоимость: {price} Срок годности: {storage_life} Вес: {weight}");
        }
        public Products(string name, int price, int storage_life, int weight)
        {
            this.name = name;
            this.price = price;
            this.storage_life = storage_life;
            this.weight = weight;

        }


    }
}
