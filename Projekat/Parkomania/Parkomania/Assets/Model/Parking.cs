using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.Model
{
    class Parking
    {
        public int Accid;
        public string Name;
        public string City;
        public string Country;
        public Location pLocation;
        public double Price;
        public DateTime startTime;
        public DateTime endTime;
        public int Capacity;
        public int freePlaces;
        public ParkingModel Model;
        public List<Information> Infos;
        public List<bool> Reserved;

        public Parking(int a, string n, string city, string country, Location pl, double price, DateTime st, DateTime et, int capacity, int freep, ParkingModel m)
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
            Infos = new List<Information>();
            Reserved = new List<bool>();
        }
        public void reserve(int i)
        {
            Reserved[i] = true;
        }
        public void editModel()
        {

        }
        public void addInformation(DateTime ca, DateTime lA, Location l, DateTime Duration)
        {
            Infos.Add(new Information(ca, lA, l, Duration));
        }
    }
}
