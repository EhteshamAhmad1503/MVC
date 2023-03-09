using AboutDetails.Models;
using MvcEntityDemo.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace MvcEntityDemo.Models
{
    public class RecordContext : DbContext
    {
        public RecordContext() : base("RecordContext")
        {
        }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}