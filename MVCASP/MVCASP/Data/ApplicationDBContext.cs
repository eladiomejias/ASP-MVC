using Microsoft.EntityFrameworkCore;
using MVCASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCASP.Data
{
    // Agregando DB Context desde el EF
    public class ApplicationDBContext: DbContext
    {
        // Constructor y pasando a la clase base
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){ 

        }

        public DbSet<Person> People { get; set; }
    }
}
