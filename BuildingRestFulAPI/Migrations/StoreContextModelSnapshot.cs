﻿// <auto-generated />
using System;
using BuildingRestFulAPI.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BuildingRestFulAPI.Migrations
{
    [DbContext(typeof(StoreContext))]
    partial class StoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BuildingRestFulAPI.Models.Account", b =>
                {
                    b.Property<Guid>("AccountId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AccountBalance")
                        .HasColumnType("decimal");

                    b.Property<Guid?>("AccountCategoryId");

                    b.Property<string>("AccountName");

                    b.Property<string>("AccountNo");

                    b.Property<string>("AccountStatus");

                    b.Property<Guid?>("BankId");

                    b.Property<Guid?>("CustomerId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<bool>("IsActive");

                    b.HasKey("AccountId");

                    b.HasIndex("AccountCategoryId");

                    b.HasIndex("BankId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("BuildingRestFulAPI.Models.AccountCategory", b =>
                {
                    b.Property<Guid>("AccountCategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("AccountCategoryId");

                    b.ToTable("AccountCategories");
                });

            modelBuilder.Entity("BuildingRestFulAPI.Models.AccountTransaction", b =>
                {
                    b.Property<int>("AccountTransactionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid?>("AccountCategoryId");

                    b.Property<string>("AccountName");

                    b.Property<string>("AccountNo");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal");

                    b.Property<string>("Pin");

                    b.HasKey("AccountTransactionId");

                    b.HasIndex("AccountCategoryId");

                    b.ToTable("AccountTransactions");
                });

            modelBuilder.Entity("BuildingRestFulAPI.Models.Agent", b =>
                {
                    b.Property<int>("AgentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DisplayName");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("AgentId");

                    b.ToTable("Agents");
                });

            modelBuilder.Entity("BuildingRestFulAPI.Models.Bank", b =>
                {
                    b.Property<Guid>("BankId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountNumberPrefix")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<string>("AgentName");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<Guid?>("CustomerId");

                    b.Property<string>("SortCode")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.HasKey("BankId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("BuildingRestFulAPI.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("AgentBank");

                    b.Property<string>("AgentName");

                    b.Property<string>("AgentUserName");

                    b.Property<string>("CustomerUserName");

                    b.Property<DateTime>("Dob")
                        .HasColumnName("dob")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasMaxLength(110);

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasColumnName("fax")
                        .HasMaxLength(50);

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnName("firstname")
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnName("gender")
                        .HasMaxLength(50);

                    b.Property<bool>("IsAgent");

                    b.Property<bool>("IsCustomer");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnName("lastname")
                        .HasMaxLength(50);

                    b.Property<Guid>("MainAddressId")
                        .HasColumnName("mainaddressid");

                    b.Property<bool>("NewsLetterOpted")
                        .HasColumnName("newsletteropted");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnName("telephone")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BuildingRestFulAPI.Models.Management", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatorId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Password");

                    b.Property<int>("RoleId");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Managements");
                });

            modelBuilder.Entity("BuildingRestFulAPI.Models.ManagementRole", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("RoleName");

                    b.HasKey("RoleId");

                    b.ToTable("ManagementRoles");
                });

            modelBuilder.Entity("BuildingRestFulAPI.Models.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MenuName")
                        .IsRequired();

                    b.Property<string>("Url")
                        .IsRequired();

                    b.HasKey("MenuId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("BuildingRestFulAPI.Models.RoleToMenu", b =>
                {
                    b.Property<int>("RoleToMenuId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MenuId");

                    b.Property<int>("RoleId");

                    b.HasKey("RoleToMenuId");

                    b.HasIndex("MenuId");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleToMenus");
                });

            modelBuilder.Entity("BuildingRestFulAPI.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal");

                    b.Property<decimal>("Charge")
                        .HasColumnType("decimal");

                    b.Property<string>("DestinationAccountName");

                    b.Property<string>("DestinationAccountNo");

                    b.Property<string>("DestinationAccountType");

                    b.Property<string>("DestinationBankName");

                    b.Property<bool>("IsFalied");

                    b.Property<bool>("IsSuccessful");

                    b.Property<Guid?>("RecieverCustomerId");

                    b.Property<Guid?>("SenderCustomerId");

                    b.Property<string>("SourceAccountName");

                    b.Property<string>("SourceAccountNo");

                    b.Property<string>("SourceAccountType");

                    b.Property<string>("SourceBankName");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal");

                    b.Property<DateTime>("TransactionDate");

                    b.Property<string>("TransactionReference");

                    b.Property<string>("TransactionStatus");

                    b.HasKey("TransactionId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("BuildingRestFulAPI.Models.Account", b =>
                {
                    b.HasOne("BuildingRestFulAPI.Models.AccountCategory", "AccountCategory")
                        .WithMany()
                        .HasForeignKey("AccountCategoryId");

                    b.HasOne("BuildingRestFulAPI.Models.Bank", "Bank")
                        .WithMany()
                        .HasForeignKey("BankId");

                    b.HasOne("BuildingRestFulAPI.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("BuildingRestFulAPI.Models.AccountTransaction", b =>
                {
                    b.HasOne("BuildingRestFulAPI.Models.AccountCategory", "AccountCategory")
                        .WithMany()
                        .HasForeignKey("AccountCategoryId");
                });

            modelBuilder.Entity("BuildingRestFulAPI.Models.Bank", b =>
                {
                    b.HasOne("BuildingRestFulAPI.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("BuildingRestFulAPI.Models.Management", b =>
                {
                    b.HasOne("BuildingRestFulAPI.Models.ManagementRole", "ManagementRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BuildingRestFulAPI.Models.RoleToMenu", b =>
                {
                    b.HasOne("BuildingRestFulAPI.Models.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BuildingRestFulAPI.Models.ManagementRole", "ManagementRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
