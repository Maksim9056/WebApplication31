using Librari.root.user;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Data.Data
{
    public class WorkForData : DbContext
    {
   
        public WorkForData(DbContextOptions<WorkForData> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;


        public DbSet<Rolles> Rolles { get; set; } = null!;
        public DbSet<UserEndpoint> UserEndpoint { get; set; } = null!;

        public WorkForData()
        {
            try
            {
                Database.EnsureCreated();
            }
            catch
            {

            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Userwebd;Username=postgres;Password=1");
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //            optionsBuilder.UseSqlite("Data Source=helloapp.db");


        //}

    }
}
//break;
//case 3: // SQL Server
//        //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
//    break;
//}

//switch (TypeSQL)
//{
//    case 1: // Postgres
//optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Userwebd;Username=postgres;Password=1");
//    break;
//case 2: // SQLite