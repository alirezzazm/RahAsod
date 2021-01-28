using DataLayer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Context
{
   public class IdentityContext :IdentityDbContext<RegisterCustomer>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
        {

        }
        public IdentityContext()
        {

        }
        public static IdentityContext Create()
        {
            return new IdentityContext();
        }
    }
}
