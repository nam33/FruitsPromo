using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeb
{
    public class Fruits
    {
        public double  appPrice = 0.45;
        public double  orgPrice = 0.55;

        public string fruitName;
        public int fruitQty;

       public  double calculatePrice(List<Fruits> fr)
        {
            int appQty=0;
            int orgQty=0;
            double appleFinalPrice = 0;
           double orangeFinalPrice = 0;
           


           for(int i= 0; i<fr.Count; i++)
           {
               if (fr[i].fruitName.Equals("apple"))
                   appQty = fr[i].fruitQty;                   
               if (fr[i].fruitName.Equals("orange"))
                   orgQty = fr[i].fruitQty;
           }

           appleFinalPrice = calculatePromoPriceItem(appQty, 2, 1) * appPrice;
           orangeFinalPrice = calculatePromoPriceItem(orgQty, 3, 2) * orgPrice;

          
           return (appleFinalPrice + orangeFinalPrice);
        }


       public int calculatePromoPriceItem(int qty, int reqdMultiItem, int applyMultiItem)
       {
           int retQty = qty; 
           retQty=   ( ((int)(qty/reqdMultiItem)) *applyMultiItem) + (int)(qty%reqdMultiItem);
           return retQty;
       }

    }
}
