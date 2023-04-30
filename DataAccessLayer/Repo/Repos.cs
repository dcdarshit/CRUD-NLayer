using DataAccessLayer.Data;
using DataAccessLayer.IRepo;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repo
{
    public class Repos:IRepos
    {
        public ApplicationDB dbContext { get; }
        public Repos(ApplicationDB dbcContext) 
        {
            dbContext = dbcContext;
        }     
        public List<Customer> GetDetails()
        {
            return dbContext.Customers.ToList();
        }
        public void CreateCustomer(Customer cst)
        {
            dbContext.Customers.Add(cst);
            dbContext.SaveChanges();
        }
       
    }
}
