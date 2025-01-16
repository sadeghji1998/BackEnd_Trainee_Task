using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_Trainee_Task
{
     class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Product A", Category = Categories.Category1, Price = 100 },
                new Product { Id = 2, Name = "Product B", Category = Categories.Category1, Price = 150 },
                new Product { Id = 3, Name = "Product C", Category = Categories.Category2, Price = 120 },
                new Product { Id = 4, Name = "Product D", Category = Categories.Category3, Price = 200 },
                new Product { Id = 5, Name = "Product E", Category = Categories.Category1, Price = 80 }
            };

            //تمرین 1
            //Category1 بازیابی تمام محصولات  

            var list = products.Where(t => t.Category == Categories.Category1).GroupBy(t => t.Category == Categories.Category1);
            Console.WriteLine("retrieve products under category1:\n");
            foreach (var Group in list)
            {
                foreach (var item in Group)
                {
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
            }


            Console.WriteLine("------------------------------------------------------------------------\n");

            //تمرین 2
            // محصول با بالاترین قیمت 
          

            var List1 = products.OrderBy(c => c.Price).Last();
            Console.WriteLine("price of most expensive product:\n");
            Console.WriteLine(List1);

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------\n");

            //تمرین 3
            // مجموع قیمت تمامی محصولات

            int sum = 0;
            var List2 = products.OrderBy(x => x.Price);
            Console.WriteLine("Total price of all products:\n");
            foreach (var item in products)
            {
                // sum جمع اعداد و ریختن آن در ظرف 
                sum += item.Price;
            }
            Console.WriteLine("Total price: {0}\n", sum);


            Console.WriteLine("------------------------------------------------------------------------\n");

            //تمرین 4
            //  محصولات  بر اساس دسته بندی گروه بندی شود

            Console.WriteLine("Product grouping:\n");
            var List3 = products.GroupBy(z => z.Category);
            //  GroupBy گروه بندی با دستور 
            foreach (var Group1 in List3)
            {
                foreach (var item in Group1)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------------------------------------------------\n");
            //تمرین 5
            //  بدست آوردن میانگین قیمت محصولات 
            Console.WriteLine("Average price of products:\n");

            int avg;
            var List4 = products.OrderBy(n => n.Price);
            foreach (var item in products)
            {
                //   sum  ریختن قیمت محصول در ظرف
                avg = item.Price;
                //انجام عمل تقسیم در زیر
                Console.WriteLine("Average price: {0}", avg / 2);
            }




            Console.ReadKey();
        }
    }
}
