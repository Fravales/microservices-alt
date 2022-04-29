using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microservices.Menu.Persistence.Adapter
{
    public static class PersistenceExtensions
    {
       
        public static void AddPersistence(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<MenuDbContext>(options =>
            options.UseSqlServer("Server=localhost;Database=DB_Pizza_Alt;Trusted_Connection=True"));
        }
    }
}
