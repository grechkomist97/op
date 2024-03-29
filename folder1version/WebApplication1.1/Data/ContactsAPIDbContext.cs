﻿using Microsoft.EntityFrameworkCore;
using WebApplication1._1.Models;

namespace WebApplication1._1.Data
{
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
