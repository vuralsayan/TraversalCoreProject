﻿using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Vural\\SQLEXPRESS;Database=TraversalDb;Trusted_Connection=True;");
        }

        public DbSet<About>? Abouts { get; set; }
        public DbSet<About2>? About2s { get; set; }
        public DbSet<Contact>? Contacts { get; set; }
        public DbSet<Destination>? Destinations { get; set; }
        public DbSet<Features>? Features { get; set; }
        public DbSet<Guide>? Guides { get; set; }
        public DbSet<NewsLetter>? NewsLetters { get; set; }
        public DbSet<SubAbout>? SubAbouts { get; set; }
        public DbSet<Testimonials>? Testimonials { get; set; }




    }
}
