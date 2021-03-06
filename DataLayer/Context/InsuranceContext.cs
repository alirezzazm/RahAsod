﻿using DataLayer.Models;
using DataLayer.Models.Admin;
using DataLayer.Models.Conditions;
using DataLayer.Models.Descriptions;
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
      

        public DbSet<CarFinancialCoverage> CarFinancialCoverages { get; set; }
        public DbSet<ConditionOfCarBody> CarBodyCondition { get; set; }
        public DbSet<ConditionOfFire> FireCondition { get; set; }
        public DbSet<DescriptionOfLifeInsurance> LifeInsurances { get; set; }
        public DbSet<DescriptionOfFireInsurance> FireInsurances { get; set; }
        public DbSet<DescriptionOfBodyInsurance> BodyInsurance { get; set; }
        public DbSet<DescriptionOfThirdPartyInsurance> ThirdPartyInsurance { get; set; }
        public DbSet<DescriptionOfCustomerInsurance> DescriptionCustomerInsurances { get; set; }
        public DbSet<InsurancesOfCustomer> CustomerInsureances { get; set; }
        public DbSet<Car> CarTypes { get; set; }
        //admin
        public DbSet<Slider> SliderPics { get; set; }
        public DbSet<OfficeInfo> OfficeInfos { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<DescriptionTexts> InsurancesDescriptionText { get; set; }
    }
}
