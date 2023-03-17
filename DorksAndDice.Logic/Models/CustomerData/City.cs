using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.Logic.Models.CustomerData
{
    public class City
    {
        public int City_Id { get; set; }
        public int Country_Id { get; set; }
        public string City_Name { get; set; }
        public string State_Name { get; set; }
        public DateTime Last_Update { get; set; }
    }
}
