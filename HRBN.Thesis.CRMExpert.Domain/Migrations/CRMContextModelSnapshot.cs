﻿// <auto-generated />
using System;
using HRBN.Thesis.CRMExpert.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HRBN.Thesis.CRMExpert.Domain.Migrations
{
    [DbContext(typeof(CRMContext))]
    partial class CRMContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ContactComment")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<DateTime>("CreDate")
                        .HasColumnType("datetime");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("ModDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("UserId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("CreDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ModDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Regon")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("TaxNo")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Discount", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreDate")
                        .HasColumnType("datetime");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DiscountVaule")
                        .HasColumnType("money");

                    b.Property<DateTime>("ModDate")
                        .HasColumnType("datetime");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContactId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<DateTime>("CreDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ModDate")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.HasIndex("ProductId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ModDate")
                        .HasColumnType("datetime");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Count")
                        .HasColumnType("money");

                    b.Property<DateTime>("CreDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<DateTime>("ModDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("Type")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ModDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Todo", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ContactId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<DateTime>("CreDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ModDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.HasIndex("UserId");

                    b.ToTable("Todos");
                });

            modelBuilder.Entity("HRBN.Thesis.CRMExpert.Domain.Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreDate")
                        .HasColumnType("datetime");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("ModDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Contact", b =>
                {
                    b.HasOne("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Customer", "Customer")
                        .WithMany("Contacts")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Contacts_Customers");

                    b.HasOne("HRBN.Thesis.CRMExpert.Domain.Core.Entities.User", "User")
                        .WithMany("Contacts")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Contacts_Users");

                    b.Navigation("Customer");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Discount", b =>
                {
                    b.HasOne("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Customer", "Customer")
                        .WithMany("Discounts")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Discounts_Customers")
                        .IsRequired();

                    b.HasOne("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Product", "Product")
                        .WithMany("Discounts")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Discounts_Products")
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Order", b =>
                {
                    b.HasOne("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Contact", "Contact")
                        .WithMany("Orders")
                        .HasForeignKey("ContactId")
                        .HasConstraintName("FK_Orders_Contacts")
                        .IsRequired();

                    b.HasOne("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Orders_Products")
                        .IsRequired();

                    b.Navigation("Contact");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Permission", b =>
                {
                    b.HasOne("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Role", "Role")
                        .WithMany("Permissions")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_Permissions_Roles")
                        .IsRequired();

                    b.HasOne("HRBN.Thesis.CRMExpert.Domain.Core.Entities.User", "User")
                        .WithMany("Permissions")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Permissions_Users")
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Todo", b =>
                {
                    b.HasOne("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Contact", "Contact")
                        .WithMany("Todos")
                        .HasForeignKey("ContactId")
                        .HasConstraintName("FK_Todos_Contacts");

                    b.HasOne("HRBN.Thesis.CRMExpert.Domain.Core.Entities.User", "User")
                        .WithMany("Todos")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Todos_Users");

                    b.Navigation("Contact");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HRBN.Thesis.CRMExpert.Domain.Core.Entities.User", b =>
                {
                    b.HasOne("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Customer", null)
                        .WithMany("Users")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Contact", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Todos");
                });

            modelBuilder.Entity("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Customer", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("Discounts");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Product", b =>
                {
                    b.Navigation("Discounts");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("HRBN.Thesis.CRMExpert.Domain.Core.Entities.Role", b =>
                {
                    b.Navigation("Permissions");
                });

            modelBuilder.Entity("HRBN.Thesis.CRMExpert.Domain.Core.Entities.User", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("Permissions");

                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
