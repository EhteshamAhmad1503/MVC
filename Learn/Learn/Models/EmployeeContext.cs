using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Learn.Models
{
    [Table("Introduction")]
    public class EmployeeContext:DbContext
    {
       public DbSet<Introduction> Introductions { get; set; }
}
}