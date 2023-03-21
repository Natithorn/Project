using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Product
    {
        private string name { get; set; }
        private string category { get; set; }
        private int Number { get; set; }

        public string GetName()
        {
            return name;
        }
        public string GetCategory()
        {
            return category;
        }
        public int GetNumber()
        {
            return Number;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setCate(string cate)
        {
            this.category= cate;
        }
        public void setNumber(int number)
        {
            this.Number = number;
        }

    }   
    

    
}
