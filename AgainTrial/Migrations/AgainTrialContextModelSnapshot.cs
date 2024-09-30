﻿// <auto-generated />
using System;
using AgainTrial.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgainTrial.Migrations
{
    [DbContext(typeof(AgainTrialContext))]
    partial class AgainTrialContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AgainTrial.Model.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("AgainTrial.Model.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ItemId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("AgainTrial.Model.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("AgainTrial.Model.ShoppingCart", b =>
                {
                    b.Property<int>("ShoppingCartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoppingCartId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("ShoppingCartId");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("ShoppingCart");
                });

            modelBuilder.Entity("ItemOrder", b =>
                {
                    b.Property<int>("ItemsItemId")
                        .HasColumnType("int");

                    b.Property<int>("OrdersOrderId")
                        .HasColumnType("int");

                    b.HasKey("ItemsItemId", "OrdersOrderId");

                    b.HasIndex("OrdersOrderId");

                    b.ToTable("ItemOrder");
                });

            modelBuilder.Entity("ItemShoppingCart", b =>
                {
                    b.Property<int>("CartsShoppingCartId")
                        .HasColumnType("int");

                    b.Property<int>("ItemsItemId")
                        .HasColumnType("int");

                    b.HasKey("CartsShoppingCartId", "ItemsItemId");

                    b.HasIndex("ItemsItemId");

                    b.ToTable("ItemShoppingCart");
                });

            modelBuilder.Entity("AgainTrial.Model.Order", b =>
                {
                    b.HasOne("AgainTrial.Model.Customer", "Customers")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("AgainTrial.Model.ShoppingCart", b =>
                {
                    b.HasOne("AgainTrial.Model.Customer", "Customers")
                        .WithOne("Carts")
                        .HasForeignKey("AgainTrial.Model.ShoppingCart", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AgainTrial.Model.Order", "Orders")
                        .WithOne("Carts")
                        .HasForeignKey("AgainTrial.Model.ShoppingCart", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customers");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ItemOrder", b =>
                {
                    b.HasOne("AgainTrial.Model.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AgainTrial.Model.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ItemShoppingCart", b =>
                {
                    b.HasOne("AgainTrial.Model.ShoppingCart", null)
                        .WithMany()
                        .HasForeignKey("CartsShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AgainTrial.Model.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AgainTrial.Model.Customer", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("AgainTrial.Model.Order", b =>
                {
                    b.Navigation("Carts");
                });
#pragma warning restore 612, 618
        }
    }
}