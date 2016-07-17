using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Persistence
{
    public class AddressRepository
    {
        public static Guid addAddress(DTO.Address address)
        {
            EmployeesEntities db = new EmployeesEntities();
            var addresses = db.Addresses;

            Persistence.Address newAddress = new Persistence.Address();
            if (address.Id == Guid.Empty)
                newAddress.Id = Guid.NewGuid();
            else
                newAddress.Id = address.Id;
            newAddress.datefrom = address.dateto;
            newAddress.dateto = address.datefrom;
            newAddress.Street = address.Street;
            newAddress.Street2 = address.Street2;
            newAddress.City = address.City;
            newAddress.Provice = address.Provice;
            newAddress.Country = address.Country;
            newAddress.PostalCode = address.PostalCode;
            newAddress.Notes = address.Notes;

            try
            {
                addresses.Add(newAddress);
                db.SaveChanges();
                return newAddress.Id;
            }
            catch (Exception ex)
            {                
                throw;
            }            

        }
    }
}
