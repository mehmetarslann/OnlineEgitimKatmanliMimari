using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    // Veritabanı tabloları ile proje sınıflarını bağlama
    public class OnlineEducationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // Veritabanı ilişkilerinin belirtilmesi
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-PVL08P0\SQLEXPRESS;Initial Catalog=OnlineEgitim;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }


        public DbSet<Egitmenler> Egitmenler { get; set; }
        public DbSet<Ogrenciler> Ogrenciler { get; set; }
        public DbSet<Urunler> Kategoriler { get; set; }
        public DbSet<Videolar> Videolar { get; set; }
        public DbSet<Puanlar> Puanlar { get; set; }
        public DbSet<Urunler> Urunler { get; set; }
        public DbSet<Sepet> Sepet { get; set; }
        public DbSet<Siparis> Siparis { get; set; }

    }
}
