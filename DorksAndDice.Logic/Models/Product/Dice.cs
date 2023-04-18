using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.Logic.Models.Product
{
    public class Dice
    {
        [Required]
        public int Dice_Id { get; set; }
        public string? Dice_Name { get; set; }
        public int Dice_Quantity { get; set; }
        public decimal Dice_Price { get; set; }
        public string? Edge { get; set; }
        public string? Color { get; set; }
        public string? Material { get; set; }
        public string? Style { get; set; }
        public string? Type { get; set; }
        public string? Size { get; set; }
        public override String ToString() => String.Format(" Id: {0}\n Name: {1}\n Quantity: {2}\n Price: {3:C}\n Edge: {4}\n Color: {5}\n Material: {6}\n Style: {7}\n Type: {8}\n Size: {9}\n",
            Dice_Id, Dice_Name, Dice_Quantity, Dice_Price, Edge, Color, Material, Style, Type, Size);
    }
}