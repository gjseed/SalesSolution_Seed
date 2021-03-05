using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace DataProject
{
    public class SalesContext : DbContext
    {
        //DbSet<Customer> customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("data source=.; initial catalog=sales; uid=CentraliaUser2021; PWD=IT410Salespwd;");
        }
    }
}
