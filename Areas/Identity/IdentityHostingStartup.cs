using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RejestrOsobZaginionych.Areas.Identity.Data;
using RejestrOsobZaginionych.Data;

[assembly: HostingStartup(typeof(RejestrOsobZaginionych.Areas.Identity.IdentityHostingStartup))]
namespace RejestrOsobZaginionych.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<RejestrOsobZaginionychContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("RejestrOsobZaginionychContextConnection")));

                services.AddDefaultIdentity<RejestrOsobZaginionychUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<RejestrOsobZaginionychContext>();
            });
        }
    }
}