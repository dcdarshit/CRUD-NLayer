using DataAccessLayer.IRepo;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.IService
{
    public interface IServices
    {
        List<Customer> GetDetails();
        void CreateCustomers(Customer cst);
    }
}
