using System;
using System.Collections.Generic;
using System.Text;

namespace PF_TinyCRM.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string VatNumber { get; set; }
        public string Phone { get; set; }
        public decimal TotalGross { get; set; }
        public DateTime Dob { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
