using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using Parkomania.dbContext;

namespace ParkomaniaMigrations
{
    [ContextType(typeof(Parking))]
    partial class ParkingModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
               .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("Parkomania.Model.Parking", b =>
            {
                b.Property<int>("id")
                    .ValueGeneratedOnAdd();
                b.Property<int>("accId");
                b.Property<string>("name");
                b.Property<string>("city");
                b.Property<int>("locationId");
                b.Property<float>("price");
                b.Property<int>("starttime");
                b.Property<int>("endtime");
                b.Property<int>("capacity");
                b.Property<int>("freeplaces");
                b.Property<int>("idInfo");
                b.Property<int>("idReserved");

                b.Key("id");
            });
            //---
            builder
               .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("Parkomania.Model.Location", b =>
            {
                b.Property<int>("id").ValueGeneratedOnAdd();
                b.Property<float>("x");
                b.Property<float>("y");
                b.Key("id");
            });
            //----
            builder.Entity("Parkomania.Model.Account", b =>
            {
                b.Property<int>("id").ValueGeneratedOnAdd();
                b.Property<string>("firstname");
                b.Property<string>("lastname");
                b.Property<string>("email");
                b.Property<string>("password");
                b.Property<string>("acctype");
                b.Key("id");
            });
            //----
            builder.Entity("Parkomania.Model.ParkingModel", b =>
            {
                b.Property<int>("id").ValueGeneratedOnAdd();
                b.Property<string>("places");
                b.Key("id");
            });
            //----
            builder.Entity("Parkomania.Model.User", b =>
            {
                b.Property<int>("id").ValueGeneratedOnAdd();
                b.Property<int>("locationid");
                b.Key("id");
            });
            //----
            builder.Entity("Parkomania.Model.Inbox", b =>
            {
                b.Property<int>("id").ValueGeneratedOnAdd();
                b.Property<string>("message");
                b.Property<string>("from");
                b.Property<string>("time");
                b.Key("id");
            });
            //----
            builder.Entity("Parkomania.Model.ParkingManager", b =>
            {
                b.Property<int>("id").ValueGeneratedOnAdd();
                b.Property<int>("parkingid");
                b.Key("id");
            });
        }
    }
}
