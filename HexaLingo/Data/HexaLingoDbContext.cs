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

        public DbSet<Word> Words { get; set; }

    }
}
