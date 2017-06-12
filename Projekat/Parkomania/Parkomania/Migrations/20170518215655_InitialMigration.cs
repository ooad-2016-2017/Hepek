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
                    pLocation = table.Column(type: "INTEGER", nullable: false),
                    price = table.Column(type: "REAL", nullable: false),
                    starttime = table.Column(type: "INTEGER", nullable: false),
                    endtime = table.Column(type: "INTEGER", nullable: false),
                    capacity = table.Column(type: "INTEGER", nullable: false),
                    freeplaces = table.Column(type: "INTEGER", nullable: false),
                    model = table.Column(type: "INTEGER", nullable: false),
                    approved = table.Column(type: "INTEGER", nullable: false)

                    
             },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parking", x => x.id);
                    //table.ForeignKey("FK_Location", y => y.locationId,"Location","id","");
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
            //------
            migration.CreateTable(
               name: "Account",
               columns: table => new
               {
                   id = table.Column(type: "INTEGER", nullable: false),
                   // .Annotation("Sqlite:Autoincrement", true)
                   firstname = table.Column(type: "TEXT", nullable: false),
                   lastname = table.Column(type: "TEXT", nullable: false),
                   email = table.Column(type: "TEXT", nullable: false),
                   password = table.Column(type: "TEXT", nullable: false),
                   acctype = table.Column(type: "TEXT", nullable: false),
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_acc", x => x.id);
               });
            //-------------------------
            migration.CreateTable(
              name: "ParkingModel",
              columns: table => new
              {
                  id = table.Column(type: "INTEGER", nullable: false),
                   // .Annotation("Sqlite:Autoincrement", true)
                  places = table.Column(type: "INTEGER", nullable: false), 
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_pmodel", x => x.id);
              });
            //----------
            migration.CreateTable(
               name: "User",
               columns: table => new
               {
                   id = table.Column(type: "INTEGER", nullable: false),
                   // .Annotation("Sqlite:Autoincrement", true)
                   locationid = table.Column(type: "INTEGER", nullable: true),
                   accid = table.Column(type: "INTEGER", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_user", x => x.id);
               });
            //-------
            migration.CreateTable(
               name: "Inbox",
               columns: table => new
               {
                   id = table.Column(type: "INTEGER", nullable: false),
                   // .Annotation("Sqlite:Autoincrement", true)
                   message = table.Column(type: "TEXT", nullable: false),
                   from = table.Column(type: "TEXT", nullable: false),
                   time = table.Column(type: "TEXT", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_inbox", x => x.id);
               });
            //-------
            migration.CreateTable(
               name: "ParkingManager",
               columns: table => new
               {
                   id = table.Column(type: "INTEGER", nullable: false),
                   // .Annotation("Sqlite:Autoincrement", true)
                   parkingid = table.Column(type: "INTEGER", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_parkingManager", x => x.id);
               });

        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Parking");
            migration.DropTable("Location");
            migration.DropTable("Account");
            migration.DropTable("ParkingModel");
        }
    }
}
