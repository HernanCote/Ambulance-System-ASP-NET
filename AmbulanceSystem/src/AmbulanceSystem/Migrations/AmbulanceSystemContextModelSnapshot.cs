using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using AmbulanceSystem.Entities;

namespace AmbulanceSystem.Migrations
{
    [DbContext(typeof(AmbulanceSystemContext))]
    partial class AmbulanceSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AmbulanceSystem.Entities.Ambulance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("AmbulanceCode");

                    b.Property<int>("AmbulanceType");

                    b.Property<string>("Plate");

                    b.Property<int>("RoadPosition");

                    b.Property<int>("State");

                    b.Property<int>("StreetPosition");

                    b.Property<DateTime>("TimeOfPosition");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("AmbulanceSystem.Entities.Direction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Avenue");

                    b.Property<int>("Number");

                    b.Property<int>("Street");

                    b.Property<int>("Type");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("AmbulanceSystem.Entities.IPS", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DirectionId");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("AmbulanceSystem.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AmbulanceId");

                    b.Property<int?>("DirectionId");

                    b.Property<int?>("IpsId");

                    b.Property<string>("Pacient");

                    b.Property<string>("Phone");

                    b.Property<int>("State");

                    b.Property<DateTime>("TimeOfRequest");

                    b.Property<int>("Type");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("AmbulanceSystem.Entities.IPS", b =>
                {
                    b.HasOne("AmbulanceSystem.Entities.Direction")
                        .WithMany()
                        .HasForeignKey("DirectionId");
                });

            modelBuilder.Entity("AmbulanceSystem.Entities.Service", b =>
                {
                    b.HasOne("AmbulanceSystem.Entities.Ambulance")
                        .WithMany()
                        .HasForeignKey("AmbulanceId");

                    b.HasOne("AmbulanceSystem.Entities.Direction")
                        .WithMany()
                        .HasForeignKey("DirectionId");

                    b.HasOne("AmbulanceSystem.Entities.IPS")
                        .WithMany()
                        .HasForeignKey("IpsId");
                });
        }
    }
}
