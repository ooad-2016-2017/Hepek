using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Parkomania.dbContext
{
    public class Location : DbContext
    {
        public DbSet<Model.Location> location { get; set; }
        public Location()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string putanjaBaze = "Ooadbaza.db";
            try
            {
                putanjaBaze = Path.Combine(ApplicationData.Current.LocalFolder.Path, putanjaBaze);
            }
            catch (InvalidOperationException) { }
            optionsBuilder.UseSqlite($"Data source={putanjaBaze}");
        }
    }
}
