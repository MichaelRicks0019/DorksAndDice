using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.Logic.Models.CustomerData
{
    public class CustomerAddress
    {
        public int Address_Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int City_Id { get; set; }
        public int Apartment_Number { get; set; }
        public string Postal_Code { get; set; }
    }
}
