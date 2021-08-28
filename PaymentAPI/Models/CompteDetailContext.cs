using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class CompteDetailContext : DbContext 
    {
        public CompteDetailContext(DbContextOptions<CompteDetailContext> options) : base(options)
        {

        }

        public DbSet<CompteDetail> CompteDetails { get; set; }
    }
}
