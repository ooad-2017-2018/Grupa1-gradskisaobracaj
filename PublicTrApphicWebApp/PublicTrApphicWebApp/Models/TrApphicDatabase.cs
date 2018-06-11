using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PublicTrApphicWebApp.Models
{
    public class TrApphicDatabase : DbContext
    {
        public TrApphicDatabase() : base("AzureConnection")
        {
        }

        public DbSet<Korisnik> Korisnik { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}