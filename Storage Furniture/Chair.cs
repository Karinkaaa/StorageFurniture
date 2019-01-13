using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Furniture
{
    public class Сhair : Furniture
    {
        public string TypeOfChair { get; set; }              // тип: скамья, стул, табурет
        public string Kind { get; set; }                     // вид: барный, кухонный, декоративный, для гостинной
        public string BackOfChair { get; set; }              // спинка: изогнутая, прямая
        public string Legs { get; set; }                     // ножки: прямые, изогнутые, на колесиках
        public string MaterialOfFrame { get; set; }          // материал каркаса: алюминий, дерево, дерево + мдф, дерево + металл, металл, пластик
        public string MaterialOfUpholstery { get; set; }     // материал обивки: вельвет, велюр, дсп, дерево, кожа, кожзам, пластик, экокожа, ткань
        
        public Сhair() { }

        public Сhair(string type, string kind, string back, string legs, string materialOfFrame, string materialOfUpholstery, string color, string manufacturer, string country, double price)
        {
            this.TypeOfChair = type;
            this.Kind = kind;
            this.BackOfChair = back;
            this.Legs = legs;
            this.MaterialOfFrame = materialOfFrame;
            this.MaterialOfUpholstery = materialOfUpholstery;
            this.Color = color;
            this.Manufacturer = manufacturer;
            this.ProducingCountry = country;
            this.Price = price;
        }

        public override string ToString()
        {
            return String.Format("***CТУЛ***\nТип: {0}\nВид: {1}\nCпинка: {2}\nНожки: {3}\nМатериал каркаса: {4}\nМатериал обивки: {5}\nЦвет: {6}\nПроизводитель: {7}\nСтрана-производитель: {8}\nЦена: {9}\n",
                this.TypeOfChair, this.Kind, this.BackOfChair, this.Legs, this.MaterialOfFrame, this.MaterialOfUpholstery, this.Color, this.Manufacturer, this.ProducingCountry, this.Price);
        }
    }
}
