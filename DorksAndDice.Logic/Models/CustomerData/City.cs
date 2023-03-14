using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.Logic.Models.CustomerData
{
    public class CustomerCity
    {
        public int City_Id { get; set; }
        public int Country_Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DateTime Last_Update { get; set; }
    }
}
