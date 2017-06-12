using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.AzureTabela
{
    class Parking
    {
        public string id { get; set; }
        public int Accid { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int pLocation { get; set; }
        public float Price { get; set; }
        public int startTime { get; set; }
        public int endTime { get; set; }
        public int Capacity { get; set; }
        public int freePlaces { get; set; }
        public int Model { get; set; }
        public int approved { get; set; }
        public Parking() { }
        public Parking(int a, string n, string city, string country, int pl, float price, int st, int et, int capacity, int freep, int m, int app)
        {
            Accid = a;
            Name = n;
            City = city;
            Country = country;
            pLocation = pl;
            Price = price;
            startTime = st;
            endTime = et;
            Capacity = capacity;
            freePlaces = freep;
            Model = m;
            approved = app;
        }
    }
}
