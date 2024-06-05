﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using posapp.Database.ContextProvider;

#nullable disable

namespace posapp.Migrations
{
    [DbContext(typeof(POSContext))]
    [Migration("20240605114700_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("posapp.Database.Models.Demands", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("item");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("createdAt")
                        .HasColumnType("date")
                        .HasColumnName("created_at");

                    b.Property<DateOnly>("updateddAt")
                        .HasColumnType("date")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("demands");
                });

            modelBuilder.Entity("posapp.Database.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("AmountReturned")
                        .HasColumnType("float")
                        .HasColumnName("returning_amount");

                    b.Property<float>("PaidAmount")
                        .HasColumnType("float")
                        .HasColumnName("paid");

                    b.Property<int>("PaymentType")
                        .HasColumnType("int")
                        .HasColumnName("payment_type");

                    b.Property<float>("SubTotal")
                        .HasColumnType("float")
                        .HasColumnName("sub_total");

                    b.Property<string>("TransactionId")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("txn_id");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("createdAt")
                        .HasColumnType("date")
                        .HasColumnName("created_at");

                    b.Property<DateOnly>("updateddAt")
                        .HasColumnType("date")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("posapp.Database.Models.OrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("createdAt")
                        .HasColumnType("date")
                        .HasColumnName("created_at");

                    b.Property<DateOnly>("updateddAt")
                        .HasColumnType("date")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("order_details");
                });

            modelBuilder.Entity("posapp.Database.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<float>("PurchasePrice")
                        .HasColumnType("float")
                        .HasColumnName("purchase_price");

                    b.Property<int>("QuantityStock")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<float>("SalePrice")
                        .HasColumnType("float")
                        .HasColumnName("sale_price");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("createdAt")
                        .HasColumnType("date")
                        .HasColumnName("created_at");

                    b.Property<DateOnly>("updateddAt")
                        .HasColumnType("date")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("posapp.Database.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("display_name");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.Property<int>("Role")
                        .HasColumnType("int")
                        .HasColumnName("role");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("username");

                    b.Property<DateOnly>("createdAt")
                        .HasColumnType("date")
                        .HasColumnName("created_at");

                    b.Property<DateOnly>("updateddAt")
                        .HasColumnType("date")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayName = "Administrator",
                            Email = "admin@pos.com",
                            Password = "",
                            Role = 0,
                            Status = 0,
                            UserName = "admin",
                            createdAt = new DateOnly(1, 1, 1),
                            updateddAt = new DateOnly(1, 1, 1)
                        });
                });

            modelBuilder.Entity("posapp.Database.Models.Demands", b =>
                {
                    b.HasOne("posapp.Database.Models.User", "User")
                        .WithMany("Demands")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("posapp.Database.Models.Order", b =>
                {
                    b.HasOne("posapp.Database.Models.User", "User")
                        .WithMany("Order")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("posapp.Database.Models.OrderDetails", b =>
                {
                    b.HasOne("posapp.Database.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("posapp.Database.Models.Products", b =>
                {
                    b.HasOne("posapp.Database.Models.User", "User")
                        .WithMany("Products")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("posapp.Database.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("posapp.Database.Models.User", b =>
                {
                    b.Navigation("Demands");

                    b.Navigation("Order");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
