﻿using DorksAndDice.Logic.Models.Product;

namespace DorksAndDice.DB.DataRepositories.ProductRepositories
{
    public interface IDiceRepository<Dice> where Dice : Logic.Models.Product.Dice
    {
        Task Delete(int id);
        Task<List<Dice>> GetAll();
        Task<List<Dice>> GetById(int id);
        Task<Dice?> GetDiceById(int DiceId);
        Task<List<Dice>> GetDiceCharacteristicBy(string? Edge = null, string? Color = null, string? Material = null, string? Style = null, string? Type = null, string? Size = null);
        Task<Product?> GetProductById(int productId);
        Task Insert(Dice entity);
        Task Update(Dice entity);
    }
}