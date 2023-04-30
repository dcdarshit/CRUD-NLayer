using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Designation { get; set; }
    }
}
