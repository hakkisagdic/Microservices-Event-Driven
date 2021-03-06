﻿// <auto-generated />
using Dispatch.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Dispatch.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Dispatch.Models.Delivery", b =>
                {
                    b.Property<int>("DispatchOrderId")
                        .HasColumnName("dispatch_order_id");

                    b.Property<string>("DeliveryAddress")
                        .HasColumnName("delivery_address");

                    b.Property<string>("FreightForwarderId")
                        .HasColumnName("freight_forwarder_id");

                    b.Property<double>("InvoiceAmount")
                        .HasColumnName("invoice_amount");

                    b.Property<int>("InvoiceId")
                        .HasColumnName("invoice_id");

                    b.HasKey("DispatchOrderId");

                    b.ToTable("delivery");
                });

            modelBuilder.Entity("Dispatch.Models.DispatchOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("DeliveryAddress")
                        .HasColumnName("delivery_address");

                    b.Property<string>("DisptachStatus")
                        .HasColumnName("disptach_status");

                    b.Property<int>("OrderId")
                        .HasColumnName("order_id");

                    b.HasKey("Id");

                    b.ToTable("dispatch_order");
                });

            modelBuilder.Entity("Dispatch.Models.Delivery", b =>
                {
                    b.HasOne("Dispatch.Models.DispatchOrder")
                        .WithOne("Delivery")
                        .HasForeignKey("Dispatch.Models.Delivery", "DispatchOrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
