using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Furniture
{
    public class Adress 
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string NumberBuild { get; set; }
        public int NumberFlat { get; set; }

        public Adress()
        {
            this.NumberFlat = 0;
        }

        public Adress(string country, string city, string street, string numberBuild) :this()
        {
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.NumberBuild = numberBuild;
        }

        public Adress(string country, string city, string street, string numberBuild, int numberFlat) :this(country, city, street, numberBuild)
        {
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.NumberBuild = numberBuild;
            this.NumberFlat = numberFlat;
        }

        public override string ToString()
        {
            if (this.NumberFlat == 0)
                return String.Format("***АДРЕС***\nСтрана: {0}\nГород: {1}\nУлица: {2}\nНомер дома: {3}\n", this.Country, this.City, this.Street, this.NumberBuild);
            return String.Format("***АДРЕС***\nСтрана: {0}\nГород: {1}\nУлица: {2}\nНомер дома: {3}\nНомер квартиры: {4}\n", this.Country, this.City, this.Street, this.NumberBuild, this.NumberFlat);
        }
    }
}
