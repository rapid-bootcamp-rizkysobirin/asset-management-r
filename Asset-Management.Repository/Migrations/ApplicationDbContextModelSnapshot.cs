﻿// <auto-generated />
using System;
using Asset_Management.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AssetManagement.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Asset_Management.Repository.AccountEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("address");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("full_name");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("role");

                    b.HasKey("Id");

                    b.ToTable("account");
                });

            modelBuilder.Entity("Asset_Management.Repository.ApprovalEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("date");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("reason");

                    b.Property<long>("RequestAssetId")
                        .HasColumnType("bigint")
                        .HasColumnName("request_asset_id");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("RequestAssetId");

                    b.ToTable("approval");
                });

            modelBuilder.Entity("Asset_Management.Repository.AssetEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("AssetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("asset_name");

                    b.Property<int>("PurchaseYear")
                        .HasColumnType("int")
                        .HasColumnName("purchase_year");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("serial_number");

                    b.Property<string>("Specification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("specification");

                    b.Property<bool>("Used")
                        .HasColumnType("bit")
                        .HasColumnName("available");

                    b.HasKey("Id");

                    b.ToTable("asset");
                });

            modelBuilder.Entity("Asset_Management.Repository.AssetHistoryEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AssetId")
                        .HasColumnType("bigint")
                        .HasColumnName("asset_id");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("location");

                    b.Property<long>("PicId")
                        .HasColumnType("bigint")
                        .HasColumnName("pic_id");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("return_date");

                    b.Property<DateTime>("SendDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("send_date");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("PicId");

                    b.ToTable("asset_history");
                });

            modelBuilder.Entity("Asset_Management.Repository.AuditEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("Antivirus")
                        .HasColumnType("bit")
                        .HasColumnName("antivirus");

                    b.Property<long>("AssetHistoryId")
                        .HasColumnType("bigint")
                        .HasColumnName("asset_history_id");

                    b.Property<string>("AssetPhotoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("asset_photo_url");

                    b.Property<string>("Condition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("condition");

                    b.Property<string>("OfficeLicenseUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("office_license_url");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("result");

                    b.Property<string>("TypeOffice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("type_office");

                    b.Property<string>("TypeWindows")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("type_windows");

                    b.Property<string>("WindowsLicenseUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("windows_license_url");

                    b.HasKey("Id");

                    b.HasIndex("AssetHistoryId");

                    b.ToTable("audit");
                });

            modelBuilder.Entity("Asset_Management.Repository.PicEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("address");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("full_name");

                    b.HasKey("Id");

                    b.ToTable("pic");
                });

            modelBuilder.Entity("Asset_Management.Repository.RequestAssetEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("PicAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("pic_address");

                    b.Property<long?>("PicId")
                        .HasColumnType("bigint")
                        .HasColumnName("pic_id");

                    b.Property<string>("PicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("pic_name");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("request_date");

                    b.Property<string>("Specification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("specification");

                    b.HasKey("Id");

                    b.ToTable("request_asset");
                });

            modelBuilder.Entity("Asset_Management.Repository.ApprovalEntity", b =>
                {
                    b.HasOne("Asset_Management.Repository.RequestAssetEntity", "RequestAsset")
                        .WithMany("Approval")
                        .HasForeignKey("RequestAssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RequestAsset");
                });

            modelBuilder.Entity("Asset_Management.Repository.AssetHistoryEntity", b =>
                {
                    b.HasOne("Asset_Management.Repository.AssetEntity", "Asset")
                        .WithMany("AssetHistory")
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Asset_Management.Repository.PicEntity", "Pic")
                        .WithMany("AssetHistories")
                        .HasForeignKey("PicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");

                    b.Navigation("Pic");
                });

            modelBuilder.Entity("Asset_Management.Repository.AuditEntity", b =>
                {
                    b.HasOne("Asset_Management.Repository.AssetHistoryEntity", "AssetHistory")
                        .WithMany("Audit")
                        .HasForeignKey("AssetHistoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssetHistory");
                });

            modelBuilder.Entity("Asset_Management.Repository.AssetEntity", b =>
                {
                    b.Navigation("AssetHistory");
                });

            modelBuilder.Entity("Asset_Management.Repository.AssetHistoryEntity", b =>
                {
                    b.Navigation("Audit");
                });

            modelBuilder.Entity("Asset_Management.Repository.PicEntity", b =>
                {
                    b.Navigation("AssetHistories");
                });

            modelBuilder.Entity("Asset_Management.Repository.RequestAssetEntity", b =>
                {
                    b.Navigation("Approval");
                });
#pragma warning restore 612, 618
        }
    }
}
