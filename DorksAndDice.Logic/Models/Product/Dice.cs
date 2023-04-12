using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.Logic.Models.Product
{
    public class Dice
    {
        [Required]
        public int Dice_Id { get; set; }
        public int Product_Id { get; set; }
        public string? Edge { get; set; }
        public string? Color { get; set; }
        public string? Material { get; set; }
        public string? Style { get; set; }
        public string? Type { get; set; }
        public string? Size { get; set; }

    }
}
