using ApiRest_Crud.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest_Crud.Context
{
    public class ContactoContext:DbContext
    {
        public ContactoContext(DbContextOptions<ContactoContext> options): base(options) { }

        public DbSet<Contacto> Contacto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
