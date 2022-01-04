using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
   public  class NorthwindContext:DbContext
    {
        //bu metot  senin projen hangi veritabanıyla ilişkiliyi belirtiğimiz  yer. 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\v11.0;Database=Northwind;Trusted_Connection=true");
        }
        //benim classım hangi tabloya karşılık geliyor.
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
