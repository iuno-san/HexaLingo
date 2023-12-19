using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using HexaLingo.Models;
using Microsoft.AspNetCore.Hosting.Server;

namespace HexaLingo.Data
{
    public class HexaLingoDbContext : DbContext
    {
        public HexaLingoDbContext(DbContextOptions<HexaLingoDbContext> options) : base(options)
        {
        }

/*        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=192.168.1.1;User=f11051;Password=CZ2S7xKXb5;Database=db_f11051");
        }*/

        public DbSet<Word> Words { get; set; }

    }
}
