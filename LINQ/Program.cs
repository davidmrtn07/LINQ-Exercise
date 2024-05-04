using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            new Program();
        }
        public class Program
        {
            List<string> designerBrands = new List<string>()
        {
            "Nike",
            "Adidas",
            "Ralph Lauren",
            "Versace"
        };

            public Program()
            {
                designerBrands.Add("Levi");

                var orderedBrands = designerBrands.OrderBy(name => name.Length);
                foreach (var brand in orderedBrands)
                {
                    Console.WriteLine(brand);
                }
            }
        }

    }
        
}
