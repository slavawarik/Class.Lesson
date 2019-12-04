using System;

public class Fruits
{ 
       
       
              public string name;
              public string color;
              public string storage_life;

              public void Info()
              {
              Console.WriteLine($"Название: {this.name} Цвет: {color} Срок годности: {storage_life}");
              }
              public Fruits() : this("Название")
              {

              }
              public Fruits(string name) : this(name, "Красный", "4 месяца")
              {

              }
              public Fruits(string name, string storage_life) : this(name, "Красный", storage_life)
              {

              }
              public Fruits(string name, string color, string storage_life)
              {
              this.name = name;
              this.color = color;
              this.storage_life = storage_life;

              }


       
   
}

