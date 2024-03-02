using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HotelManagementSystemII.Entity;

public class HotelDbContext : DbContext
{
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<UserAccount> UserAccounts { get; set; }
    public string DbPath { get; }

    public HotelDbContext() { 
        var folder = Environment.SpecialFolder.MyDocuments;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "HotelDN.db");

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source = {DbPath} ");
    }

}
