using System;
using System.Collections.Generic;
using System.Text;

namespace Application25
{
    class Cat
    {
        private string name;
        public string _name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Cat(string name)
        {
            this.name = name;
        }
        public void sayMiau()
        {
            Console.WriteLine("{0}: Miauu", name);
        }
    }
}
