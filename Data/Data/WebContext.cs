using Librari.root.user;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class WebContext : DbContext
    {
        public WebContext(DbContextOptions<WebContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;


        public DbSet<Rolles> Rolles { get; set; } = null!;
        public DbSet<UserEndpoint> UserEndpoint { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Userwebd;Username=postgres;Password=1");


        }
    }
}
