using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_Trainee_Task
{
     class Categories
    {
        //  Categories تعریف فیلد های استاتیک کلاس 
        //فیلد ها عدد گذاری شدند تا زمان نمایش خروجی صفر نمایش داده نشود
        public static int Category1 { get; set; } = 1;
        public static int Category2 { get; set; } = 2;
        public static int Category3 { get; set; } = 3;

        //یک متود سازنده خالی 
        public Categories() { }


        //  ToString از طریق متودCategories چاپ فیلد های کلاس 
        public override string ToString()
        {

            return String.Format("Category1: {0}\tCategory2: {1}\tCategory3: {2}", Category1, Category2, Category3);
        }
    }
}
