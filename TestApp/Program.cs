using DorksAndDice.DB.DataRepositories;
using DorksAndDice.DB.DataRepositories.CustomerDataRepositories;
using DorksAndDice.DB.DataRepositories.ProductRepositories;
using DorksAndDice.DB.DBAccess;
using DorksAndDice.DB.Interfaces.ProductInterfaces;
using DorksAndDice.Logic.Interfaces;
using DorksAndDice.Logic.Models.CustomerData;
using DorksAndDice.Logic.Models.Product;
using Microsoft.Extensions.Configuration;

Dice dice = new Dice() { Dice_Id = 1, Dice_Name = "Blue Set", Color = "Blue", Dice_Price = 20.99m, Dice_Quantity = 5, Edge = "Sharp", Material = "Resin", Size = "Normal", Style = "Color", Type = "Set" };
Console.WriteLine(dice.ToString());
