using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Magazine : Press
    {


        private string quality;

        public string Quality { get { return quality; } set { quality = value; } }

        public Magazine(int copies, string name, double price, string quality) : base(copies, name, price)
        {
            this.quality = quality;
        }

        new public double Cost()
        {
            if (quality == "hight")
            {
                return base.Cost() + ((base.Cost() / 100) * 10);
            }
            else if (quality == "low")
            {
                return base.Cost() - ((base.Cost() / 100) * 10);
            }
            else
            {
                return base.Cost();
            }
        }

        public override void OutPut()
        {

          base.OutPut();
          Console.WriteLine($"Качество: {quality}");
         }









    










    }
}
