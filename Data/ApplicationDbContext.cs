using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PenaP4.Models;
using PenaP4.Models.Blog;

namespace PenaP4.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Contact> Messages { get; set; }
        public DbSet<PenaP4.Models.Blog.Blog> Blog { get; set; }
        public DbSet<PenaP4.Models.Blog.Post> Post { get; set; }
    }
}
