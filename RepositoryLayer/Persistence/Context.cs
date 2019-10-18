using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DomainLayer.Models.Department;
using RepositoryLayer.Persistence.EntityConfigurations;

namespace RepositoryLayer.Persistence
{
    public class Context : DbContext
    {
        public Context()
            :base("ContextRepository")
        {

        }

        public virtual DbSet<DepartmentModel> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DepartmentConfiguration());
        }
    }
}
