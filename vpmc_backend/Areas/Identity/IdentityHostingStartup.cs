using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using vpmc_backend.Areas.Identity.Data;
using vpmc_backend.Data;

//[assembly: HostingStartup(typeof(vpmc_backend.Areas.Identity.IdentityHostingStartup))]
namespace vpmc_backend.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            
            });
        }
    }
}