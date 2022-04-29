using microservices.Menu.DomainApi.Models;
using Microsoft.EntityFrameworkCore;

namespace microservices.Menu.Persistence.Adapter
{
    public class MenuDbContext : DbContext
    {
       
        public MenuDbContext(DbContextOptions<MenuDbContext> options) : base(options)
        {
            
        }



        public DbSet<Pizza> Pizzas { get; set; }
        //  public DbSet Deals { get; set; }

    }
}