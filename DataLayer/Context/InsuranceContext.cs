using DataLayer.Models;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Context
{
   public class InsuranceContext : DbContext
    {
        public InsuranceContext(DbContextOptions<InsuranceContext> options) : base(options)
        {

        }
        public InsuranceContext()
        {

        }

        public DbSet<DescriptionOfBodyInsurance> BodyInsurance { get; set; }
        public DbSet<DescriptionOfThirdPartyInsurance> ThirdPartyInsurance { get; set; }
        public DbSet<DescriptionOfCustomerInsurance> CustomerInsurance { get; set; }
        public DbSet<InsurancesOfCustomer> InsurancesOfCustomer { get; set; }
        public DbSet<RegisterCustomer> CustomerRegisteration { get; set; }
        public DbSet<LoginCustomer> CustomerLogin { get; set; }
    }
}
