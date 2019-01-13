using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Furniture
{
    public class Table : Furniture
    {
        public string Kind { get; set; }                    // вид: барный, обеденный
        public string Shape { get; set; }                   // форма: квадратный, круглый, овальный, прямоугольный, треугольный
        public double Height { get; set; }                  // высота 
        public double Width { get; set; }                   // ширина 
        public string MaterialOfTableTop { get; set; }      // материал столешницы: дсп, дерево, закаленное стекло, дерево + стекло, металл, мдф, мдф + дерево, стекло, пластик
        public string MaterialOfTableCase { get; set; }     // материал корпуса: дсп, дерево, сталь, закаленное стекло, дерево + стекло, металл, мдф, мдф + металл, мдф + дерево, стекло
       
        public Table() { }

        public Table(string kind, string shape, double height, double width, string materialTop, string materialCase, string color, string manufacturer, string country, double price)
        {
            this.Kind = kind;
            this.Shape = shape;
            this.Height = height;
            this.Width = width;
            this.MaterialOfTableTop = materialTop;
            this.MaterialOfTableCase = materialCase;
            this.Color = color;
            this.Manufacturer = manufacturer;
            this.ProducingCountry = country;
            this.Price = price;
        }

        public override string ToString()
        {
            return String.Format("***CТОЛ***\nВид: {0}\nФорма: {1}\nВысота: {2}\nШирина: {3}\nМатериал столешницы: {4}\nМатериал корпуса: {5}\nЦвет: {6}\nПроизводитель: {7}\nСтрана-производитель: {8}\nЦена: {9}\n",
                this.Kind, this.Shape, this.Height, this.Width, this.MaterialOfTableTop, this.MaterialOfTableCase, this.Color, this.Manufacturer, this.ProducingCountry, this.Price);
        }
    }
}
