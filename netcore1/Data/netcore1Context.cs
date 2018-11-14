using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace netcore1.Models
{
    public class netcore1Context : DbContext
    {
        public netcore1Context (DbContextOptions<netcore1Context> options)
            : base(options)
        {
        }

        public DbSet<netcore1.Models.Student> Student { get; set; }
    }
}
