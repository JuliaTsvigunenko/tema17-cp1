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

            //1
            List<Person> persons = new List<Person>();
            persons.Add(new Person(17, "Серафима", "Лебедева"));
            persons.Add(new Employee(17, "Юлия", "Цвигуненко", "EXE", "Дизайнер"));
            persons.Add(new Students(17, "Арина", "Крижановская", new DateTime(2006, 5, 17), 2));
            foreach (var st in persons)
            {
                st.Print();
            }


            //2



            Console.ReadKey();




        }
    }
}
