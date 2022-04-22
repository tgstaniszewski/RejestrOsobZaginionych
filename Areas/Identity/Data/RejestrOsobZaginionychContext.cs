using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RejestrOsobZaginionych.Areas.Identity.Data;
using RejestrOsobZaginionych.Models;

namespace RejestrOsobZaginionych.Data
{
    public class RejestrOsobZaginionychContext : IdentityDbContext<RejestrOsobZaginionychUser>
    {
        public RejestrOsobZaginionychContext(DbContextOptions<RejestrOsobZaginionychContext> options)
            : base(options)
        {
            
        }

        public DbSet<MissingModel> Zaginieni { get; set; }
        public DbSet<PictureModel> Zdjecia { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
