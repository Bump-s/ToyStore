﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace ToyStore.Models
{
    public class ToyContext : DbContext
    {
            public DbSet<Toy> Toys { get; set; }
            public DbSet<Purchase> Purchases { get; set; }
    }
}