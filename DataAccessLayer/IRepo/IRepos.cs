using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepo
{
    public interface IRepos
    {
        List<Customer> GetDetails();
        void CreateCustomer(Customer cst);
    }
}
