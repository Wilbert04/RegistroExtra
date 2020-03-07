using Microsoft.EntityFrameworkCore;
using RegistroExtra.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroExtra.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = RegistroDB.db");
        }
    }
}
