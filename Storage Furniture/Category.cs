using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Furniture
{
    public class Category
    {
        public List<Furniture> arrayArticles;
        public Type typeOfArticle;
        public int Count
        {
            get { return this.arrayArticles.Count; }
        }

        private Category()
        {
            this.arrayArticles = new List<Furniture>();
        }

        public Category(Furniture furniture) :this()
        {
            this.typeOfArticle = furniture.GetType();
            this.AddArticle(furniture);
        }

        public void AddArticle(Furniture furniture)
        {
            this.arrayArticles.Add(furniture);
        }

        public void RemoveArticle(Furniture furniture)
        {
            this.arrayArticles.Remove(furniture);
        }

        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < this.Count; i++)
                res += this.arrayArticles[i] + "\n";
            return res;
        }
    }
}
