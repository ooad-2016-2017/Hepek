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
    class Parking: DbContext
    {
        public DbSet<Model.Parking> parking { get; set; }
        public DbSet<Model.Location> location { get; set; }
        public DbSet<Model.Account> account { get; set; }
        public DbSet<Model.User> user { get; set; }
        public DbSet<Model.Admin> admin { get; set; }
        public DbSet<Model.ParkingModel> pmodels { get; set; }
        public DbSet<Model.ParkingManager> pmanager { get; set; }
        public DbSet<Model.Message> inbox { get; set; }

        public Parking()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string putanjaBaze = "Ooadbaza2.db";
            try
            {
                putanjaBaze = Path.Combine(ApplicationData.Current.LocalFolder.Path,putanjaBaze);
            }
            catch (InvalidOperationException) { }
            optionsBuilder.UseSqlite($"Data source={putanjaBaze}");
        }
    }
}
