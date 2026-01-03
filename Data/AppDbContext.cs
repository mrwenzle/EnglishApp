using EnglishApp.Models;
using Microsoft.EntityFrameworkCore;
using EnglishApp.Models;
using System;
using System.IO;

namespace EnglishApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<WordCard> WordCards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            var dbPath = Path.Join(path, "myenglishpal.db");

            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}