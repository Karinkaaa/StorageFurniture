using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Furniture
{
    public class Cupboard : Furniture
    {
        public string TypeOfCupboard { get; set; }       // тип: книжный, распашный, шкаф-купе, шкаф для посуды, шкаф-пенал
        public int CountDoors { get; set; }              // количество дверей
        public double Height { get; set; }               // высота
        public double Width { get; set; }                // ширина 
        public string FacadeMaterial{ get; set; }        // материал фасада: дсп, дсп + зеркало, зеркало, зеркало с рисунком, ламинированная дсп, фотопечать, матовое стекло
        public string MaterialOfBody { get; set; }       // материал корпуса: дсп, дерево, мдф, ламинированная дсп
       
        public Cupboard() { }

        public Cupboard(string type, int countDoors, double height, double width, string facadeMaterial, string materialOfbBody, string color, string manufacturer, string country, double price)
        {
            this.TypeOfCupboard = type;
            this.CountDoors = countDoors;
            this.Height = height;
            this.Width = width;
            this.FacadeMaterial = facadeMaterial;
            this.MaterialOfBody = materialOfbBody;
            this.Color = color;
            this.Manufacturer = manufacturer;
            this.ProducingCountry = country;
            this.Price = price;
        }

        public override string ToString()
        {
            return String.Format("***ШКАФ***\nТип: {0}\nКоличество дверей: {1}\nВысота: {2}\nШирина: {3}\nМатериал фасада: {4}\nМатериал корпуса: {5}\nЦвет: {6}\nПроизводитель: {7}\nСтрана-производитель: {8}\nЦена: {9}\n",
                this.TypeOfCupboard, this.CountDoors, this.Height, this.Width, this.FacadeMaterial, this.MaterialOfBody, this.Color, this.Manufacturer, this.ProducingCountry, this.Price);
        }
    }
}
