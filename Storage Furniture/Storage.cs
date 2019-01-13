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
        private List<Category> list;
        private readonly Category EMPTY_CATEGORY;

        private Storage()
        {
            this.list = new List<Category>();
            this.EMPTY_CATEGORY = new Category(new Furniture());
        }

        public Storage(Adress adress) :this()
        {
            this.AdressStorage = adress;
        }

        // добавление мебели
        public void AddFurniture(Furniture furniture)
        {
            Category category = GetCategoryByType(furniture.GetType());
            if (category != EMPTY_CATEGORY)
                category.AddArticle(furniture);
            else
                this.list.Add(new Category(furniture));
        }

        // удаление мебели
        public void RemoveFurniture(Furniture furniture)
        {
            Category category = GetCategoryByType(furniture.GetType());
            if (category != EMPTY_CATEGORY)
                category.RemoveArticle(furniture);
        }

        // поиск категории мебели по типу
        private Category GetCategoryByType(Type typeOfArticle)
        {
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].typeOfArticle == typeOfArticle)
                    return this.list[i];
            }
            return EMPTY_CATEGORY;
        }
        
        // получить количество мебели данного типа на складе
        public int GetCountFurnitureOfType(Type type)
        {
            return (this.GetCategoryByType(type) != EMPTY_CATEGORY) ? this.GetCategoryByType(type).Count : 0;
        }

        // получить количество всей мебели на складе
        public int GetCountAllFurniture()
        {
            int count = 0;
            for (int i = 0; i < this.list.Count; i++)
                count += this.list[i].Count;
            return count;
        }

        // получить информацию о мебели конкретного типа по идексу
        public string GetInfoByIndex(Type type, int idx)
        {
            Category category = this.GetCategoryByType(type);
            if (idx < category.Count)
                return category.arrayArticles[idx].ToString();
            throw new Exception("Выход за границы массива!");            
        }
        
        // получить информацию о всей категории мебели данного типа
        public string GetInfoAboutAllCategoryOf(Type type)
        {
            Category category = this.GetCategoryByType(type);
            return category.ToString();           
        }        

        // изменить цену конкретной категории мебели конкретному товару
        public void ChangePrice(Type type, int idx, double price)
        {
            Category category = this.GetCategoryByType(type);
            if (idx < category.Count)
                category.arrayArticles[idx].Price = price;
            else
                throw new Exception("Выход за границы массива!");
        }

        // получить информацию о всех товарах склада
        public string GetInfoAllStorage()
        {
            string res = "";
            for (int i = 0; i < this.list.Count; i++)
                res += this.list[i].ToString() + "\n\n\n";
            return res;
        }

        // посмотреть адресс склада
        public string GetAdress()
        {
            return this.AdressStorage.ToString();
        }
    }
}
