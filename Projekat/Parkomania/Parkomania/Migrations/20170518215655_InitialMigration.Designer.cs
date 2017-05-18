using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using Parkomania.dbContext;

namespace ParkomaniaMigrations
{
    [ContextType(typeof(Parking))]
    partial class InitialMigration
    {
        public override string Id
        {
            get { return "20170518215655_InitialMigration"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("Parkomania.Model.Parking", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Key("id");
                });
        }
    }
}
