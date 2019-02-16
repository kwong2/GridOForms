using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Forms.Models;

    public class FormsContext : DbContext
    {
        public FormsContext (DbContextOptions<FormsContext> options)
            : base(options)
        {
        }

        public DbSet<Forms.Models.Form> Form { get; set; }
    }
