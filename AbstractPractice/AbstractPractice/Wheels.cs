using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPractice
{
    class Wheels : Parts
    {
        Rimowa rimowa;

        public Wheels(Rimowa rimowa)
        {
            this.rimowa = rimowa;
        }

        override
        public String getDescription()
        {
            return rimowa.getDescription() + " with exta Wheels";
        }

        override
        public double cost()
        {
            return 10.00 + rimowa.cost();
        }

        override
        public String color()
        {
            return rimowa.color();
        }

        
    }
}
