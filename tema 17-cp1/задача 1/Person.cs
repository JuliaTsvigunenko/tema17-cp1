using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {

        private int age;

        private string name;

        private string surame;


        public int Age { get { return age; } set { age = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Surame { get { return surame; } set { surame = value; } }


        public Person()
        {

        }


        public Person(int age)
        {
            this.age = age;
        }


        public Person(int age, string name) : this(age)
        {
            this.name = name;
        }


        public Person(int age, string name, string surname) : this(age, name)
        {
            this.surame = surname;
        }


        virtual public void Print()
        {
            Console.WriteLine($"Возраст сотрудника: {age}\nИмя сотрудника: {name}\nФамилия сотрудника: {surame}");
        }



        //public void ShowInfo()
        //{
        //    Console.WriteLine($"Возраст сотрудника: {age}\nИмя сотрудника: {name}\nФамилия сотрудника: {surame}");
        //}
















    }
}
