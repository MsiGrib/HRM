using HRM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM
{
    public class application_db_context : DbContext
    {
        public DbSet<admin> admins { get; set; }
        public DbSet<bonus> bonus { get; set; }
        public DbSet<worker> workers { get; set; }

        public application_db_context(string connection_str) : base(connection_str)
        {
            Database.Initialize(false);
        }
    }
}
