using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWork2021.Core
{
    public class AppDBContext:IdentityDbContext<IdentityUser>
    {
        public AppDBContext(DbContextOptions options): base(options) 
        {
           // Database.EnsureCreated(); //Создание БД если ее нет
        }
       

        public DbSet<Product> Product { get; set; }

        //Дабавление информации в базу при настройке миграции при update-database
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            Worker worker = new Worker();
            var Data = worker.GetData("https://nikopol.org/");

            builder.Entity<Product>().HasData(
                Data
                );
            


        }

    }
    
}
