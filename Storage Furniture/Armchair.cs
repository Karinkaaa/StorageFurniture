using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Furniture
{
    public class Armchair : Furniture
    {
        public string TypeOfArmchair { get; set; }           // тип: козетка, кресло, кресло-качалка, пуфик
        public string Kind { get; set; }                     // вид: раскладные, нераскладные
        public double Height { get; set; }                   // высота  
        public double Width { get; set; }                    // ширина 
        public string MaterialOfUpholstery { get; set; }     // материал обивки: вельвет, велюр, дсп, дерево, кожа, кожзам, пластик, экокожа, ткань
        
        public Armchair() { }

        public Armchair(string type, string kind, double height, double width, string materialOfUpholstery, string color, string manufacturer, string country, double price)
        {
            this.TypeOfArmchair = type;
            this.Kind = kind;
            this.Height = height;
            this.Width = width;
            this.MaterialOfUpholstery = materialOfUpholstery;
            this.Color = color;
            this.Manufacturer = manufacturer;
            this.ProducingCountry = country;
            this.Price = price;
        }

        public override string ToString()
        {
            return String.Format("***КРЕСЛО***\nТип: {0}\nВид: {1}\nВысота: {2}\nШирина: {3}\nМатериал обивки: {4}\nЦвет: {5}\nПроизводитель: {6}\nСтрана-производитель: {7}\nЦена: {8}\n",
                this.TypeOfArmchair, this.Kind, this.Height, this.Width, this.MaterialOfUpholstery, this.Color, this.Manufacturer, this.ProducingCountry, this.Price);
        }
    }
}
