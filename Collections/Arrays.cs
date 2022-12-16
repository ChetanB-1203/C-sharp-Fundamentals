using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public  class Arrays
    {  

        
        static void Main2(string[] args)
        {
            BusRoute[] allRoutes = BusRouteRepository.IntializeRoutes();
            Console.WriteLine("Where do you want to go ?");
            string location =Console.ReadLine();

            BusRoute []routes =FindBusTo(allRoutes, location);

            if (routes != null)
                foreach (BusRoute route in routes)
                {
                    Console.WriteLine($"You can use  route {route}");
                }
            else
                Console.WriteLine($"No routes go to  {location}");
            Console.ReadLine(); 
        }

        public static BusRoute[] FindBusTo(BusRoute[] routes,string location)
        {

            return Array.FindAll(routes,route => route.Origin == location || route.Destination==location);
            /*foreach(BusRoute route in routes)
            {
                if(route.Origin==location || route.Destination==location)
                    return route;
            }
            return null;*/
        }
    }

    public class BusRouteRepository
    {
        public static BusRoute[] IntializeRoutes()
        {
            return new BusRoute[]
            {
                new BusRoute(40,"Jalgaon","Pune"),
                new BusRoute(45,"Nagpur","Kolhapur"),
                new BusRoute(123,"Aurangabad","Ratnagiri"),
                new BusRoute(178,"Pune","Mumbai"),
            };
        } 
    }

    public class BusRoute
    {

        public int Number { get; }

        public string Origin { get; }

        public string Destination { get; }

        
        public BusRoute(int number, string origin, string destination)
        {
            Number = number;
            Origin = origin;
            Destination = destination;
        }

        public override string ToString() => $"{Number} : {Origin} -> {Destination}";


    }
}
