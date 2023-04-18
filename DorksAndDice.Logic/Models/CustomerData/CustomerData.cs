using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.Logic.Models.CustomerData
{
    public class CustomerData
    {
        [Required]
        public int Customer_Id { get; set; }
        [Required]
        public string? First_Name { get; set; }
        public string? Middle_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Email { get; set; }
        public string? Phone_Number { get; set; }
        public int Address_Id { get; set; }
        public bool Status_Active { get; set; }
        public DateTime Create_Date { get; set; }
        public DateTime Last_Logged_On { get; set; }

    }
}
