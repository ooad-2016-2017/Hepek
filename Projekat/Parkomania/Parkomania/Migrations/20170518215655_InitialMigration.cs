using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace ParkomaniaMigrations
{
    public partial class InitialMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Parking",
                columns: table => new {
                    id = table.Column(type: "INTEGER", nullable: false),
                    //Annotation("Sqlite:Autoincrement", true)
                    accId = table.Column(type: "INTEGER", nullable: false),
                    name = table.Column(type: "TEXT", nullable: false),
                    city = table.Column(type: "TEXT", nullable: false),
                    country = table.Column(type: "TEXT", nullable: false),
                    locationId = table.Column(type: "INTEGER", nullable: false),
                    price = table.Column(type: "REAL", nullable: false),
                    starttime = table.Column(type: "INTEGER", nullable: false),
                    endtime = table.Column(type: "INTEGER", nullable: false),
                    capacity = table.Column(type: "INTEGER", nullable: false),
                    freeplaces = table.Column(type: "INTEGER", nullable: false),
                    idInfo = table.Column(type: "INTEGER", nullable: false),
                    idReserved = table.Column(type: "INTEGER", nullable: false)

                    
             },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parking", x => x.id);
                    table.ForeignKey("FK_Location", y => y.locationId,"Location","id","");
                });
            migration.CreateTable(
               name: "Location",
               columns: table => new
               {
                   id = table.Column(type: "INTEGER", nullable: false),
                    // .Annotation("Sqlite:Autoincrement", true)
                    x = table.Column(type: "REAL", nullable: false),
                   y = table.Column(type: "REAL", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Location", x => x.id);
               });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Parking");
            migration.DropTable("Location");
        }
    }
}
