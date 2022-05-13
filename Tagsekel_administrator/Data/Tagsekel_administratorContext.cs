#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tagsekel_administrator.Admin;

namespace Tagsekel_administrator.Data
{
    public class Tagsekel_administratorContext : DbContext
    {
        public Tagsekel_administratorContext (DbContextOptions<Tagsekel_administratorContext> options)
            : base(options)
        {
        }

        public DbSet<Tagsekel_administrator.Admin.Class> Class { get; set; }
        public object Name { get; internal set; }
    }
}
