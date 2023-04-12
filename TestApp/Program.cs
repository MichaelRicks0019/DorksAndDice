using DorksAndDice.DB.DataRepositories;
using DorksAndDice.DB.DataRepositories.CustomerDataRepositories;
using DorksAndDice.DB.DataRepositories.ProductRepositories;
using DorksAndDice.DB.DBAccess;
using DorksAndDice.Logic.Interfaces;
using DorksAndDice.Logic.Models.CustomerData;
using DorksAndDice.Logic.Models.Product;
using Microsoft.Extensions.Configuration;

ISqlDataAccess i = new SqlDataAccess();
IDiceRepository<Dice> Dice = new DiceRepository<Dice>(i);
List<Dice> type = Dice.GetDiceCharacteristicBy(Edge: "Sharp");
Console.ReadLine();
