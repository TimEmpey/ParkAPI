// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using National.Models;

namespace National.Migrations
{
    [DbContext(typeof(NationalContext))]
    partial class NationalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("National.Models.Activity", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("ParkId")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ActivityId");

                    b.HasIndex("ParkId");

                    b.ToTable("Activities");

                    b.HasData(
                        new
                        {
                            ActivityId = 1,
                            Name = "Hiking",
                            ParkId = 1,
                            Size = 10,
                            Type = "Outdoors"
                        },
                        new
                        {
                            ActivityId = 2,
                            Name = "Climbing",
                            ParkId = 1,
                            Size = 3,
                            Type = "Outdoors"
                        },
                        new
                        {
                            ActivityId = 3,
                            Name = "Tour",
                            ParkId = 2,
                            Size = 30,
                            Type = "Outdoors"
                        },
                        new
                        {
                            ActivityId = 5,
                            Name = "Hiking",
                            ParkId = 3,
                            Size = 10,
                            Type = "Outdoors"
                        },
                        new
                        {
                            ActivityId = 6,
                            Name = "Camping",
                            ParkId = 3,
                            Size = 6,
                            Type = "Outdoors"
                        },
                        new
                        {
                            ActivityId = 7,
                            Name = "Kayaking",
                            ParkId = 4,
                            Size = 2,
                            Type = "Outdoors"
                        },
                        new
                        {
                            ActivityId = 8,
                            Name = "Food",
                            ParkId = 4,
                            Size = 5,
                            Type = "Indoors"
                        },
                        new
                        {
                            ActivityId = 9,
                            Name = "Climbing",
                            ParkId = 5,
                            Size = 3,
                            Type = "Outdoors"
                        },
                        new
                        {
                            ActivityId = 10,
                            Name = "Camping",
                            ParkId = 5,
                            Size = 6,
                            Type = "Outdoors"
                        },
                        new
                        {
                            ActivityId = 11,
                            Name = "Kayaking",
                            ParkId = 6,
                            Size = 2,
                            Type = "Outdoors"
                        },
                        new
                        {
                            ActivityId = 12,
                            Name = "Food",
                            ParkId = 6,
                            Size = 5,
                            Type = "Indoors"
                        });
                });

            modelBuilder.Entity("National.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Camping")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Camping = "Yes",
                            Name = "Yellowstone",
                            State = "Wyoming"
                        },
                        new
                        {
                            ParkId = 2,
                            Camping = "No",
                            Name = "Grand Canyon",
                            State = "Arizona"
                        },
                        new
                        {
                            ParkId = 3,
                            Camping = "Yes",
                            Name = "Yosemite",
                            State = "California"
                        },
                        new
                        {
                            ParkId = 4,
                            Camping = "No",
                            Name = "Zion",
                            State = "Virginia"
                        },
                        new
                        {
                            ParkId = 5,
                            Camping = "Yes",
                            Name = "Rocky Mountain",
                            State = "Colorado"
                        },
                        new
                        {
                            ParkId = 6,
                            Camping = "Yes",
                            Name = "Glacier",
                            State = "Montana"
                        });
                });

            modelBuilder.Entity("National.Models.Activity", b =>
                {
                    b.HasOne("National.Models.Park", "Park")
                        .WithMany("Activities")
                        .HasForeignKey("ParkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Park");
                });

            modelBuilder.Entity("National.Models.Park", b =>
                {
                    b.Navigation("Activities");
                });
#pragma warning restore 612, 618
        }
    }
}
