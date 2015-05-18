using alexdodd.net.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace alexdodd.net
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<EmailSignUp> EmailSignUps { get; set; }
    }
}