using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmplAppSolution.Domain.EmplAppEnum;
using EmplAppSolution.Domain;

namespace EmplAppSolution.Domain
{
    class AddressManager
    {
        public static Guid addAddress(EmployeeApp.DTO.Address address)
        {

            EmplAppSolution.Domain.Address newAddress = EmplAppSolution.Domain.AddressManager.buildAddress(address);
            Guid guidAddress = EmployeeApp.Persistence.AddressRepository.addAddress(address);
            return guidAddress;                       
        }

        private static EmplAppSolution.Domain.Address buildAddress(EmployeeApp.DTO.Address address)
        {
            EmplAppSolution.Domain.Address newAddress = new EmplAppSolution.Domain.Address();
            newAddress.Id = address.Id;
            newAddress.Street = address.Street;
            newAddress.Street2 = address.Street2;
            newAddress.City = address.City;
            newAddress.Provice = EmplAppSolution.Domain.AddressManager.checkProvince(address.Provice);
            newAddress.Country = EmplAppSolution.Domain.AddressManager.checkCountry(address.Country);
            newAddress.PostalCode = address.PostalCode;
            newAddress.Notes = address.Notes;
            return newAddress;
        }

        private static EmplAppSolution.Domain.EmplAppEnum.Province checkProvince(string inProvince)
        {
            EmplAppSolution.Domain.EmplAppEnum.Province province;
            Enum.TryParse(inProvince, out province);
            return province;                                            
        }

        private static EmplAppSolution.Domain.EmplAppEnum.Country checkCountry(string inCountry)
        {
            EmplAppSolution.Domain.EmplAppEnum.Country country;
            Enum.TryParse(inCountry, out country);
            return country;
        }
    }
}
