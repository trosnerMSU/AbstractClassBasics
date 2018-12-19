using System;

namespace AbstractPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Rimowa TannersBag = new Original("Black");
            Console.WriteLine("Tanner's new " + TannersBag.getDescription() + " will cost him: " + TannersBag.cost());

        }
    }
}
