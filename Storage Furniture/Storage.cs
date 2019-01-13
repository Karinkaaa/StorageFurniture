using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Furniture
{
    public class Storage
    {
        public Adress AdressStorage { get; set; }
        private List<Furniture> list;
        private List<Type> categories;

        private Storage()
        {
            this.list = new List<Furniture>();
            categories = new List<Type>();
        }

        public Storage(Adress adress) :this()
        {
            this.AdressStorage = adress;
        }

        // добавление мебели
        public void AddFurniture(Furniture furniture)
        {
            this.list.Add(furniture);
            ChangeArrayCategories(furniture);
        }

        // удаление мебели
        public void RemoveFurniture(Furniture furniture)
        {
            this.list.Remove(furniture);
        }

        // существует ли на складе такой тип мебели
        private bool IsExistsType(Type type)
        {
            for(int i = 0; i < this.categories.Count; i++)
            {
                if (this.categories[i] == type)
                    return true;
            }
            return false;
        }

        // получить количество мебели данного типа на складе
        public int GetCountFurnitureOfType(Type type)
        {
            int count = 0;
            if(IsExistsType(type))
            {
                for(int i = 0; i < this.list.Count; i++)
                {
                    if (this.list[i].GetType() == type)
                        count++;
                }
            }
            return count;
        }

        // получить количество всей мебели на складе
        public int GetCountAllFurniture()
        {
            return this.list.Count;
        }

        // получить массив мебели конкретного типа
        private List<Furniture> GetArraySpecificType(Type type)
        {
            List<Furniture> arrayFurnitures = new List<Furniture>();
            for(int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].GetType() == type)
                    arrayFurnitures.Add(this.list[i]);
            }
            return arrayFurnitures;
        }

        // получить информацию о мебели конкретного типа по идексу
        public string GetInfoByIndex(Furniture furniture, int idx)
        {
            List<Furniture> arrayFurnitures = this.GetArraySpecificType(furniture.GetType());
            if (idx < arrayFurnitures.Count)
                return arrayFurnitures[idx].ToString();
            throw new Exception("Выход за границы массива!");            
        }
        
        // получить информацию о всей категории мебели данного типа
        public string GetInfoAboutAllCategoryOf(Type Type)
        {
            string res = "";
            for (int i = 0; i < this.list.Count; i++)
            {
                if (list[i].GetType() == Type)
                    res += this.list[i] + "\n";
            }
            return res;
        }

        // получить индекс передаваемого объекта 
        private int GetIndexObject(Furniture furniture)
        {
            for(int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i] == furniture)
                    return i;
            }
            throw new Exception("Данного объекта не существует в базе!");
        }

        // изменить цену конкретной категории мебели конкретному товару
        public void ChangePrice(Furniture furniture, double price)
        {
            int idx = this.GetIndexObject(furniture);
            this.list[idx].Price = price;
        }

        // повторяется ли тип данной мебели в массиве категорий мебели
        private bool IsRepeatTypeInArrayCategories(Type type)
        {
            for (int i = 0; i < this.categories.Count; i++)
            {
                if (this.categories[i] == type)
                    return true;
            }
            return false;
        }

        // изменение массива категорий мебели
        private void ChangeArrayCategories(Furniture furniture)
        {
            if (!IsRepeatTypeInArrayCategories(furniture.GetType()))
                this.categories.Add(furniture.GetType());
        }

        // получить информацию о всех товарах склада
        public string GetInfoAllStorage()
        {
            string res = "";
            for (int i = 0; i < this.categories.Count; i++)
                res += this.GetInfoAboutAllCategoryOf(this.categories[i]) + "\n\n\n";
            return res;
        }

        // посмотреть адресс склада
        public string GetAdress()
        {
            return this.AdressStorage.ToString();
        }
    }
}
