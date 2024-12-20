using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Customers.Models
{
 public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
 {
        public required DbSet<Customer> Clients { get; set; }
 }
}