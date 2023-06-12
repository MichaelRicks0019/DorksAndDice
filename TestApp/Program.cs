using DorksAndDice.DB.DataRepositories;
using DorksAndDice.DB.DataRepositories.CustomerDataRepositories;
using DorksAndDice.DB.DataRepositories.ProductRepositories;
using DorksAndDice.DB.DBAccess;
using DorksAndDice.DB.Interfaces.ProductInterfaces;
using DorksAndDice.DB.UOW;
using DorksAndDice.Logic.Interfaces;
using DorksAndDice.Logic.Models.CustomerData;
using DorksAndDice.Logic.Models.Product;
using Microsoft.Extensions.Configuration;

ISqlDataAccess _db = new SqlDataAccess();
UnitOfWork UOW = new UnitOfWork(_db);

var i = await UOW.Dice.GetById(1);
Console.WriteLine(i);
