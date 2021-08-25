using Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlServer.EntityFrameWork
{
    public class NorthWindContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB;
                                        Database = C:\USERS\TURKUAZ\SOURCE\REPOS\CARSSQLSERVER\SQLSERVER\CARS.MDF;
                                        Trusted_Connection = true"); 
        }

        public DbSet<Cars> cars { get; set; }

        public DbSet<Colors> colors { get; set; }

        public DbSet<Brands> brands { get; set; }



    }
}
