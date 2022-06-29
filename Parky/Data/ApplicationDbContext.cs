using Microsoft.EntityFrameworkCore;
using Parky.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Threading.Tasks;


namespace Parky.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<NationalPark> NationalaParks { get; set; }
        public DbSet<Trail> Trails { get; set; }
    }
}
