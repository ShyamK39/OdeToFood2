using Microsoft.EntityFrameworkCore;
using OdeToFood2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood2.Data
{
    public class OdeToFoodDbContext : DbContext
    {
        public OdeToFoodDbContext(DbContextOptions<OdeToFoodDbContext> options)
            : base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
