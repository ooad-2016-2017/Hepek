using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.AzureTabela
{
    class Parking
    {
        public int idp { get; set; }
        public int Accid { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public int locationid { get; set; }
        public float price { get; set; }
        public int starttime { get; set; }
        public int endtime { get; set; }
        public int capacity { get; set; }
        public int freeplaces { get; set; }
        public int idInfo { get; set; }
        public int idReserved { get; set; }
        public int modelid { get; set; }
        public int approved { get; set; }
    }
}
