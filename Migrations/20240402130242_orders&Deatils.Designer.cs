﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineStore.DB;

#nullable disable

namespace OnlineStore.Migrations
{
    [DbContext(typeof(Db_Class))]
    [Migration("20240402130242_orders&Deatils")]
    partial class ordersDeatils
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OnlineStore.Models.Class_Categories", b =>
                {
                    b.Property<int>("cat_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cat_id"), 1L, 1);

                    b.Property<string>("cat_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cat_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("show_menu")
                        .HasColumnType("int");

                    b.HasKey("cat_id");

                    b.ToTable("tbl_categories");
                });

            modelBuilder.Entity("OnlineStore.Models.Class_Orders", b =>
                {
                    b.Property<int>("Order_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Order_Id"), 1L, 1);

                    b.Property<string>("Order_Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Order_InvoiceNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Order_toatlAmount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Order_userId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Order_Id");

                    b.ToTable("tbl_Orders");
                });

            modelBuilder.Entity("OnlineStore.Models.Class_Orders_Details", b =>
                {
                    b.Property<int>("Orders_details_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Orders_details_id"), 1L, 1);

                    b.Property<string>("Order_Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Order_InvoiceNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Order_userId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Orders_Details_product")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Orders_details_Product_Qty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Orders_details_Product_price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Orders_details_id");

                    b.ToTable("tbl_Orders_Detail");
                });

            modelBuilder.Entity("OnlineStore.Models.Class_Products", b =>
                {
                    b.Property<int>("p_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("p_id"), 1L, 1);

                    b.Property<string>("p_desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("p_img_1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("p_img_2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("p_img_3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("p_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("p_price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("p_price_old")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sub_cat_id")
                        .HasColumnType("int");

                    b.HasKey("p_id");

                    b.ToTable("tbl_products");
                });

            modelBuilder.Entity("OnlineStore.Models.Class_subcategories", b =>
                {
                    b.Property<int>("sub_cat_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("sub_cat_id"), 1L, 1);

                    b.Property<int>("cat_id")
                        .HasColumnType("int");

                    b.Property<string>("sub_cat_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sub_cat_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("sub_cat_id");

                    b.ToTable("tbl_sub_cat");
                });

            modelBuilder.Entity("OnlineStore.Models.Class_UserModel", b =>
                {
                    b.Property<int>("u_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("u_id"), 1L, 1);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("u_id");

                    b.ToTable("tbl_users");
                });
#pragma warning restore 612, 618
        }
    }
}
