using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Press
    {


        private int copies;

        private string name;

        private double price;

        public int Copies { get { return copies; } set { copies = value; } }
        public string Name { get { return name; } set { name = value; } }
        public double Price { get { return price; } set { price = value; } }


        public Press(int copies, string name, double price)
        {
            this.copies = copies;
            this.name = name;
            this.price = price;
        }


        /// <summary>
        /// Метод для вычисления тиража
        /// </summary>
        public double Cost()
        {
            return price * copies;
        }


        virtual public void OutPut()
        {
            Console.WriteLine($"Кол-во копий: {copies}\nНазвание: {name}\nЦена: {price}");
        }



    }
}
