using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Furniture
{
    public class Furniture
    {
        public string Color { get; set; }                // цвет
        public string Manufacturer { get; set; }         // производитель: BRW, IKEA, Myau, MatroLuxe
        public string ProducingCountry { get; set; }     // страна-производитель
        public double Price { get; set; }                // цена
    }
}