using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }
    }


    public class A
    {
        public virtual void Do()
        {

        }
    }
    public class B:A
    {
        public override void Do() //override yazıp bir boşluk bırakınca do methodunu bize vermiş olur
        { //Do methodu üstünde değişiklik yapabiliriz
            base.Do();
        }
    }
}
