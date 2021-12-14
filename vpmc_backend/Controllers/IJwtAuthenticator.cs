using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vpmc_backend.Models;
using vpmc_backend.Areas.Identity.Data;


namespace vpmc_backend.Controllers
{
    interface IJwtAuthenticator
    {
        void injectDbContext(vpmc_backendUser context);
        string authenticate(string username, string password);
        int validate(string token);
    }
}
