using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Furniture
{
    public class Bed : Furniture 
    {
        public string TypeOfBed { get; set; }                   // тип: односпальные, двуспальные, полуторные, двухъярусные
        public double Length { get; set; }                      // длина
        public double Width { get; set; }                       // ширина 
        public string BaseUnderMattress { get; set; }           // основание под матрас: брус, дсп, ламели, металлические рейки, нет
        public string MaterialOfUpholstery { get; set; }        // материал обивки: искусственная кожа, кожа, нет, текстиль, ткань, экокожа
        public string MaterialOfFrame { get; set; }             // материал каркаса: дсп, дерево, дерево + мдф, лдсп, металл
        
        public Bed() { }

        public Bed(string type, double length, double width, string baseUnderMattress, string upholstery, string frame, string color, string manufacturer, string country, double price)
        {
            this.TypeOfBed = type;
            this.Length = length;
            this.Width = width;
            this.BaseUnderMattress = baseUnderMattress;
            this.MaterialOfUpholstery = upholstery;
            this.MaterialOfFrame = frame;
            this.Color = color;
            this.Manufacturer = manufacturer;
            this.ProducingCountry = country;
            this.Price = price;
        }

        public override string ToString()
        {
            return String.Format("***КРОВАТЬ***\nТип: {0}\nДлина: {1}\nШирина: {2}\nОснование под матрас: {3}\nМатериал обивки: {4}\nМатериал каркаса: {5}\nЦвет: {6}\nПроизводитель: {7}\nСтрана-производитель: {8}\nЦена: {9}\n",
                this.TypeOfBed, this.Length, this.Width, this.BaseUnderMattress, this.MaterialOfUpholstery, this.MaterialOfFrame, this.Color, this.Manufacturer, this.ProducingCountry, this.Price);
        }
    }
}
