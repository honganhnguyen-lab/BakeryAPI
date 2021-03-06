// <auto-generated />
using BakeryWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BakeryWeb.Migrations
{
    [DbContext(typeof(BakeryContext))]
    partial class BakeryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BakeryWeb.Models.Bakery", b =>
                {
                    b.Property<int>("BakeryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BakeryDay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BakeryExpire")
                        .HasColumnType("int");

                    b.Property<string>("BakeryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BakeryPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BakeryStatus")
                        .HasColumnType("int");

                    b.HasKey("BakeryID");

                    b.ToTable("Bakerys");
                });
#pragma warning restore 612, 618
        }
    }
}
