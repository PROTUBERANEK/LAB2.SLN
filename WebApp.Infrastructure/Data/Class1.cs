﻿using Microsoft.EntityFrameworkCore;


namespace WebApp.Infrastructure
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) :base(options) 
        { 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}
