﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyTruongHoc.Models;

#nullable disable

namespace QuanLyTruongHoc.Migrations
{
    [DbContext(typeof(QuanLyTruongHocConText))]
    [Migration("20230716184356_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyCSVC.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ghiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hienTrang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.Property<string>("tenCoSoVatChat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Device");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyCSVC.DeviceBorrow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdDevice")
                        .HasColumnType("int");

                    b.Property<int>("IdDoiTuong")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngayMuon")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("DeviceBorrow");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyConNguoi.StudentInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CMND")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdLop")
                        .HasColumnType("int");

                    b.Property<string>("danToc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diaChiThuongTru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("hoTenCha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hoTenMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ngaySinh")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("ngheNghiep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ngheNghiepCha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ngheNghiepMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nienKhoa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("noiSinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StudentInfo");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyConNguoi.TeacherInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CMND")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bangCap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("chuyenMon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("danToc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diaChiThuongTru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gioiTinh")
                        .HasColumnType("int");

                    b.Property<int>("luong")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ngaySinh")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("ngheNghiep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("noiSinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phanQuyen")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TeacherInfo");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdGiaoVien")
                        .HasColumnType("int");

                    b.Property<int>("Khoi")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("namRaTruong")
                        .HasColumnType("int");

                    b.Property<int>("namVaoTruong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.GiaoVienMonHoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdGiaoVien")
                        .HasColumnType("int");

                    b.Property<int>("IdMonHoc")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("giaoVienMonHocs");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.GradeProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Diem")
                        .HasColumnType("real");

                    b.Property<int>("IdHocSinh")
                        .HasColumnType("int");

                    b.Property<int>("IdKiThi")
                        .HasColumnType("int");

                    b.Property<DateTime>("createTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("GradeProfile");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.HocBa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdHocSinh")
                        .HasColumnType("int");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("HocBa");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.KiThi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdMonHoc")
                        .HasColumnType("int");

                    b.Property<string>("ghiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("heSo")
                        .HasColumnType("real");

                    b.Property<int>("khoi")
                        .HasColumnType("int");

                    b.Property<string>("namHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KiThi");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.KiThiLopHoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdGiaoVien")
                        .HasColumnType("int");

                    b.Property<int>("IdKiThi")
                        .HasColumnType("int");

                    b.Property<int>("IdLopHoc")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("KiThiLopHoc");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.MonHoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MonHoc");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdGiaoVien")
                        .HasColumnType("int");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Note");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.TKB", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<string>("KhoiHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KiHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("TKB");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.TKBItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdGiaoVien")
                        .HasColumnType("int");

                    b.Property<int>("IdLop")
                        .HasColumnType("int");

                    b.Property<int>("IdMonHoc")
                        .HasColumnType("int");

                    b.Property<int>("IdTKB")
                        .HasColumnType("int");

                    b.Property<string>("day")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tietHoc")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TKBItem");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.ThongBao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdGiaoVien")
                        .HasColumnType("int");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("loaiThongBao")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ThongBao");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.ThongBaoLink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdGiaoVienDt")
                        .HasColumnType("int");

                    b.Property<int>("IdHocSinh")
                        .HasColumnType("int");

                    b.Property<int>("IdLopHoc")
                        .HasColumnType("int");

                    b.Property<int>("IdThongBao")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ThongBaoLopHoc");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyThuChi.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DoiTuong")
                        .HasColumnType("int");

                    b.Property<int>("IdPayment")
                        .HasColumnType("int");

                    b.Property<DateTime?>("dateCreated")
                        .HasColumnType("datetime2");

                    b.Property<float>("fee")
                        .HasColumnType("real");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("typeTransaction")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyThuChi.TransactionUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("TimeCreate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TransactionUser");
                });
#pragma warning restore 612, 618
        }
    }
}