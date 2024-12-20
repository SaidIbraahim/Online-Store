using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace Customers.Models
{
 public class Customer
 {
 [Key]
 public int ID { get; set; }
 public String Name { get; set; } = "";
 public String Address { get; set; } = "";
 public String Country { get; set; } = "";
 public DateTime DOB { get; set; }
 [Display(Name = "Time Created")]
 public DateTime TimeCreated { get; set; } = DateTime.Now;
 }
}