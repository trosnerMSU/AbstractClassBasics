﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPractice
{
    public class Original : Rimowa
    {
        public String setColor;

        public Original(String color)
        {
            base.description = "Original Rimowa";

            if(color == "Black" || color == "Silver" || color == "Bronze")
            {
                this.setColor = color;
               
            }
            
        }

        public override String getDescription()
        {
            return base.getDescription();
        }

        public override String color()
        {
            return setColor;
        }

        
        public override double cost()
        {
            return 1000.00;
        }

        
        

    }
}
