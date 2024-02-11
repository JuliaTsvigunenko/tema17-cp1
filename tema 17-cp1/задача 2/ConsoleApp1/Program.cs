using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Press> press = new List<Press>();
            press.Add(new Press(4, "Детство", 100));

            List<Magazine> magazines = new List<Magazine>();
            magazines.Add(new Magazine(2, "Астрология", 400, "высокое"));

            foreach (var pres in press)
            {
                pres.OutPut();
                Console.WriteLine($"Стоимость тиража:{pres.Cost()}");
            }
            foreach (var magazine in magazines)
            {
                magazine.OutPut();
                Console.WriteLine($"Стоимость тиража:{magazine.Cost()}");
            }
           


            Console.ReadKey();













        }
    }
}
