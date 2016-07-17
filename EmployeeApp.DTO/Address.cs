using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.DTO
{
    public class Address
    {
        public System.Guid Id { get; set; }
        public System.DateTime datefrom { get; set; }
        public System.DateTime dateto { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Provice { get; set; }
        public string PostalCode { get; set; }
        public string Notes { get; set; }

        public Address(string street, string street2, string City, string country, string province, string PostalCode = "", string Notes = "")
        {
            this.Id = Guid.NewGuid();
            this.datefrom = DateTime.Now;
            this.dateto = new DateTime(9999, 12, 31);
            this.Street = street;
            this.Street2 = street2;
            this.City = City;
            this.Country = country;
            this.Provice = province;
            this.PostalCode = PostalCode;
            this.Notes = Notes;
        }
    }
}
