using CalorieTrackingApp.DAL.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DAL.EntityConfiguration
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasData(new Admin
            {
                Id = 1,
                AdminName = "admin",
                Password = "admin123",
                Name = "Admin_Name",
                Surname = "admin@example.com",
                CreatedDate = new DateTime(2024, 10, 10, 21, 34, 51, 585, DateTimeKind.Local).AddTicks(9444)
                //Her çalıştığında create date i oluşturmaması için sabit bir değer koyduk bu değer üzerinden çalışacak.
                //Her seferinde yeni seed data oluşturmasın diye.
            });

            builder.Property(a => a.AdminName)
                .IsRequired()
                .HasColumnType("varchar(30)");

            builder.Property(d => d.Password)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(a => a.Surname)
                .IsRequired()
                .HasMaxLength(30);
        }
    }
}
//protected override void OnModelCreating(ModelBuilder modelBuilder)
//{
//    //danısmanno pk oldu
//    modelBuilder.Entity<Danisman>().HasKey(d => d.DanismanNo);

//    //ad propertysi aynı kalacak ama karşılığı dbde Name olacak.
//    modelBuilder.Entity<Danisman>().Property(d => d.Ad).HasColumnName("Name");

//    //Danisman.cs sınıf ismi aynı kalsın ama kaşılık gelen tablo ismi advisors olsun.
//    modelBuilder.Entity<Danisman>().ToTable("Advisors");

//    //Ad kolonunun data tipini nvarchar(max) dan nvarchar(50) yapcaz
//    modelBuilder.Entity<Danisman>().Property(d => d.Ad).HasMaxLength(50);

//    //Soyad kolonunu varchar(60) olsun
//    modelBuilder.Entity<Danisman>().Property(d => d.Soyad).HasColumnType("varchar(60)"); //Eğer nvarcar varchar gibi tip değiştireceksem hascolumntype diyorum ama sadece boyutu değiştireceksem üstteki

//    //Deger propertysi için kolon oluşturulmasın
//    modelBuilder.Entity<Danisman>().Ignore(d => d.Deger);

//    //Unique key yapmak = sicilno
//    modelBuilder.Entity<Danisman>().HasIndex(d => d.SicilNo).IsUnique();

//    //1-1 ilişki için one.to.one

//    //modelBuilder.Entity<Ogrenci>().HasOne(o => 
//    //    o.Transcript).WithOne(t => 
//    //    t.Ogrenci).HasForeignKey<Ogrenci>(o => 
//    //    o.TranscriptNumarasi);

//    modelBuilder.Entity<Transcript>().HasOne(t =>
//        t.Ogrenci).WithOne(o =>
//        o.Transcript).HasForeignKey<Ogrenci>(o =>
//        o.TranscriptNumarasi);

//    //üstteki ikisi aynı şey.

//    //1-N ilişki için one.to.many

//    //modelBuilder.Entity<Ogrenci>().HasOne(o 
//    //    => o.Danisman).WithMany(d 
//    //    => d.Ogrenciler).HasForeignKey(o 
//    //    => o.DanismanNumarasi);

//    modelBuilder.Entity<Danisman>().HasMany(d =>
//    d.Ogrenciler).WithOne(o =>
//    o.Danisman).HasForeignKey(o =>
//    o.DanismanNumarasi);

//    //m-n ilişkisi için many.to.many
//    //Ogrencisi ve Dersi özelliklerini composite key olacağını belirtelim.

//    modelBuilder.Entity<OgrenciDers>().HasKey(k => new { k.Ogrencisi, k.Dersi });

//    modelBuilder.Entity<OgrenciDers>().HasOne(od =>
//    od.Ogrenci).WithMany(o =>
//    o.OgrenciDersler).HasForeignKey(od =>
//    od.Ogrencisi);

//    modelBuilder.Entity<OgrenciDers>().HasOne(od =>
//    od.Ders).WithMany(o =>
//    o.OgrenciDersler).HasForeignKey(od =>
//    od.Dersi);
