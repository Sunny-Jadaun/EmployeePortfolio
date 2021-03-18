using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EmployeePortfolio.Models;

namespace EmployeePortfolio.DataContext
{
    public class empDBContext : DbContext
    {
        public empDBContext() : base(nameOrConnectionString: "empdatabase")
        {

        }
        public virtual DbSet<empInfo> empObject { get; set; }
    }
}