using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    public class Cat
    {
        public Cat(string farve)
        {
            Farve = farve;
        }

        public string Farve { get; set; }

        public string nyFarve()
        {
            Farve = "blå";
            return Farve;
        }
    }
}
