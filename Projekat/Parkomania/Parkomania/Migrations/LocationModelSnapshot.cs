using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using Parkomania.dbContext;

namespace ParkomaniaMigrations
{
    [ContextType(typeof(Parking))]
    partial class LocationModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("Parkomania.Model.Location", b =>
                {
                    b.Property<int>("id").ValueGeneratedOnAdd();
                    b.Property<float>("X");
                    b.Property<float>("Y");
                    b.Key("id");
                });
        }
    }
}
