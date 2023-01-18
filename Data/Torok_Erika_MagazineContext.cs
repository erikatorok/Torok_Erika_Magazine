using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Torok_Erika_Magazine.Models;

namespace Torok_Erika_Magazine.Data
{
    public class Torok_Erika_MagazineContext : DbContext
    {
        public Torok_Erika_MagazineContext (DbContextOptions<Torok_Erika_MagazineContext> options)
            : base(options)
        {
        }

        public DbSet<Torok_Erika_Magazine.Models.Client> Client { get; set; } = default!;
    }
}
