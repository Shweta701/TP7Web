using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TP7Web.Model
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("Data Source=CHETUIWK1142\\SQLEXPRESS;Initial Catalog=shweta_TP7;Integrated Security=True;Pooling=False") { }
        
        public DbSet<Employee> Employees { get; set; }
    }
}