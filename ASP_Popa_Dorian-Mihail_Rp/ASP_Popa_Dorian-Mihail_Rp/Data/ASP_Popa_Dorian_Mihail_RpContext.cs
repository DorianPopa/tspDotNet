using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP_Popa_Dorian_Mihail_Rp.Models;

namespace ASP_Popa_Dorian_Mihail_Rp.Data
{
    public class ASP_Popa_Dorian_Mihail_RpContext : DbContext
    {
        public ASP_Popa_Dorian_Mihail_RpContext (DbContextOptions<ASP_Popa_Dorian_Mihail_RpContext> options)
            : base(options)
        {
        }

        public DbSet<ASP_Popa_Dorian_Mihail_Rp.Models.Movie> Movie { get; set; }
    }
}
