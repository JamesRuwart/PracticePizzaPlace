﻿using Microsoft.EntityFrameworkCore;
using PracticePizzaPlace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePizzaPlace.Data
{
    public class PizzaContext : DbContext
    {
        public PizzaContext(DbContextOptions<PizzaContext> options) : base(options)
        {
        }
            public DbSet<Employee> Employees { get; set; }
        

    }
}