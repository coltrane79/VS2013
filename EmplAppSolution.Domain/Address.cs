using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplAppSolution.Domain
{
    public class Address
    {
        public System.Guid Id { get; set; }
        public System.DateTime datefrom { get; set; }
        public System.DateTime dateto { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public EmplAppSolution.Domain.EmplAppEnum.Country Country { get; set; }
        public EmplAppSolution.Domain.EmplAppEnum.Province Provice { get; set; }
        public string PostalCode { get; set; }
        public string Notes { get; set; }
    }
}
