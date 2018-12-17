using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPractice
{
    public abstract class Rimowa
    {
        public String description = "Unknown Case";

        public virtual String getDescription()
        {
            return description;
        }
        public abstract double cost();
        public abstract String color();


    }
}
