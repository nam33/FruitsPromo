using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeb
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Fruits> myFruit = new List<Fruits>();

            Console.WriteLine("enter qty for apples");
            string app = Console.ReadLine();

            Fruits fapple = new Fruits();

            fapple.fruitName = "apple";
            fapple.fruitQty = Convert.ToInt32(app);
            
            Console.WriteLine("enter qty for oranges");
            string org = Console.ReadLine();

            Fruits forange = new Fruits();

            forange.fruitName = "orange";
            forange.fruitQty = Convert.ToInt32(org);


            myFruit.Add(fapple);
            myFruit.Add(forange);

            Fruits f = new Fruits();

            Console.WriteLine("Total price is " + f.calculatePrice(myFruit));
        }
    }
}
