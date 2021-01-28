using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BizContactHelper.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BizContactHelper.Data
{
    public class BizContactHelperContext : DbContext
    {
        public BizContactHelperContext(DbContextOptions<BizContactHelperContext> options) : base(options)
        {
        }

        public DbSet<SalesContact> SalesContacts { get; set; }
        public DbSet<DeveloperContact> DeveloperContacts { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().ToTable("Contact");
        }
    }
}
