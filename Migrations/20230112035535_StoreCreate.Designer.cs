// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using rdbms_net.repositories;

#nullable disable

namespace Tokonyadia.Migrations
{
    [DbContext(typeof(TokonyadiaContext))]
    [Migration("20230112035535_StoreCreate")]
    partial class StoreCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Tokonyadia.Model.Customer", b =>
                {
                    b.Property<int>("customer_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("customer_id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("customer_name")
                        .IsRequired()
                        .HasColumnType("NVarchar(100)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("phone_number")
                        .IsRequired()
                        .HasColumnType("NVarchar(14)");

                    b.HasKey("customer_id");

                    b.HasIndex("email");

                    b.HasIndex("phone_number");

                    b.ToTable("customer", "dbo");
                });

            modelBuilder.Entity("Tokonyadia.Model.Store", b =>
                {
                    b.Property<int>("store_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("store_id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("phone_number")
                        .IsRequired()
                        .HasColumnType("NVarchar(14)");

                    b.Property<string>("siup_number")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("store_name")
                        .IsRequired()
                        .HasColumnType("NVarchar(100)");

                    b.HasKey("store_id");

                    b.HasIndex("phone_number");

                    b.HasIndex("siup_number");

                    b.ToTable("Store");
                });
#pragma warning restore 612, 618
        }
    }
}
