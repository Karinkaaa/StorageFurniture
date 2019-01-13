using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Furniture
{
    public class Sofa : Furniture
    {
        public string TypeOfSofa { get; set; }                  // тип: офисный, детский, прямой, угловой
        public string Kind { get; set; }                        // вид: раскладные, нераскладные
        public string MechanismTransformation { get; set; }     // механизм трансформации: аккордеон, выкатной, дельфин, еврокнижка, пума, сабля, седафлекс
        public double Width { get; set; }                       // ширина 
        public string MaterialOfUpholstery { get; set; }        // материал обивки: велюр, искусственная кожа, кожа, текстиль, экокожа
        
        public Sofa() { }

        public Sofa(string type, string kind, string mechanismTransformation, double width, string materialOfUpholstery, string color, string manufacturer, string country, double price)
        {
            this.TypeOfSofa = type;
            this.Kind = kind;
            this.MechanismTransformation = mechanismTransformation;
            this.Width = width;
            this.MaterialOfUpholstery = materialOfUpholstery;
            this.Color = color;
            this.Manufacturer = manufacturer;
            this.ProducingCountry = country;
            this.Price = price;
        }

        public override string ToString()
        {
            return String.Format("***ДИВАН***\nТип: {0}\nВид: {1}\nМеханизм трансформации: {2}\nШирина: {3}\nМатериал обивки: {4}\nЦвет: {5}\nПроизводитель: {6}\nСтрана-производитель: {7}\nЦена: {8}\n",
                this.TypeOfSofa, this.Kind, this.MechanismTransformation, this.Width, this.MaterialOfUpholstery, this.Color, this.Manufacturer, this.ProducingCountry, this.Price);
        }
    }
}
