// <auto-generated />
using System;
using Batch_DET_2022.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Batch_DET_2022.Migrations
{
    [DbContext(typeof(BookContext))]
    [Migration("20220906093106_initialcode")]
    partial class initialcode
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Batch_DET_2022.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Batch_DET_2022.Models.Order", b =>
                {
                    b.Property<int>("Order_ID")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int")
                        .HasColumnName("OrderAmt");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("custID")
                        .HasColumnType("int");

                    b.HasKey("Order_ID");

                    b.HasIndex("custID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Batch_DET_2022.Models.Order", b =>
                {
                    b.HasOne("Batch_DET_2022.Models.Customer", "cust")
                        .WithMany("Orders")
                        .HasForeignKey("custID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cust");
                });

            modelBuilder.Entity("Batch_DET_2022.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
