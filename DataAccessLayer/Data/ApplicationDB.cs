using DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data
{
    public class ApplicationDB :DbContext
    {
        public ApplicationDB(DbContextOptions<ApplicationDB> options):base(options)
        {
            
        }
        public DbSet<Customer> Customers { get; set; }  
    }
}
