using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using T1708E.Models;

[assembly: HostingStartup(typeof(T1708E.Areas.Identity.IdentityHostingStartup))]
namespace T1708E.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<NewContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("NewContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<NewContext>();
            });
        }
    }
}