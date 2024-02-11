using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Students : Person
    {


        private DateTime bh;

        private int course;

        public DateTime Bh { get { return bh; } set { bh = value; } }
        public int Course { get { return course; } set { course = value; } }


        public Students(int age, string name, string surname, DateTime bh, int course) : base(age, name, surname)
        {
            this.bh = bh;
            this.course = course;

        }


        public override void Print()
        {
            base.Print();
            Console.WriteLine($"День рождения: {bh}\nКурс: {course}");
        }





    }
}
