using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoteWebApp.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
    }
}
