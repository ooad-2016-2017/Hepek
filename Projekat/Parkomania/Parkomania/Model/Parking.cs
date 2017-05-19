using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.Model
{
    public class Parking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int Accid;
        public string Name;
        public string City;
        public string Country;
        public int pLocation;
        public float Price;
        public int startTime;
        public int endTime;
        public int Capacity;
        public int freePlaces;
        public ParkingModel Model;
        public List<Information> Infos;
        public List<bool> Reserved;

        public Parking(int a, string n, string city, string country, int pl, float price, int st, int et, int capacity, int freep, ParkingModel m)
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
