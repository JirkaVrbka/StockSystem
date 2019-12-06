﻿using System.Data.Entity;
using RestaurantManager.DAL.Config;
using RestaurantManager.DAL.Models;

namespace RestaurantManager.DAL
{
    public class RestaurantManagerDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<StockItem> Items { get; set; }
        public DbSet<MenuItemAmount> ItemAmounts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Stock> Stocks { get; set; }

        public DbSet<MenuItem> MenuItems { get; set; }

        public RestaurantManagerDbContext() : base(EntityFrameworkInstaller.ConnectionString)
        {
            Database.SetInitializer(new RestaurantManagerInitializer());
        }

        public RestaurantManagerDbContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer(new RestaurantManagerInitializer());
        }
    }
}