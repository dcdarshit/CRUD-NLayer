using BusinessAccessLayer.IService;
using DataAccessLayer.IRepo;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Services
{
    public class Services: IServices
    {
        //<!--Instance-->
        private readonly IRepos _dataaccess;
       public Services(IRepos dataaccess)
        {
            _dataaccess = dataaccess;
        }
        //-------------//
        public List<Customer> GetDetails() 
        {
            return _dataaccess.GetDetails();
        }
        public void CreateCustomers(Customer cst)
        {
            _dataaccess.CreateCustomer(cst);
        }

    }
}
