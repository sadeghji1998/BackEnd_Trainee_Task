using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_Trainee_Task
{
     class Product
    {
        //  Product تعریف فیلد های کلاس 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Category { get; set; }
        public int Price { get; set; }


        //یک متود سازنده خالی 
        public Product() { }
        //یک متود سازنده
        public Product(int Id, string Name, int Category, int Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Category = Category;
            this.Price = Price;
        }

        //  ToString از طریق متود  Product چاپ فیلد های کلاس 
        public override string ToString()
        {
            return String.Format("ID: {0}\t\tName: {1}\t\tCategory: {2}\tPrice: {3}", Id, Name, Category, Price);
        }











    }
}
