using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersTypes
{
    public class Restaurant
    {    
        public int  OrderNo{ get; set; }
        public string ItemName { get; set; }    

        public int Quantity { get; set; }

        public int Price { get; set; }  

        public Restaurant (int orderno,string itemname ,int price,int quantity= 1)
        {
            this.OrderNo = orderno;
            this.ItemName = itemname;
            this.Quantity = quantity;
            this.Price = price;
        }
        
      
        static void Main(string[] args)
        {   
            Restaurant r = new Restaurant(1, "Pizza", 500, 2);
          
            //optional parameters
            Restaurant r1 = new Restaurant(2, "Berger", 250); // we have set default quantity in constructor

            //named parameters : here we can mention values with parameters names
            Restaurant r2 = new Restaurant(orderno: 3, itemname: "Vadapav", quantity: 2, price: 15);

            
            
            Console.ReadLine(); 

        }
    }
}
