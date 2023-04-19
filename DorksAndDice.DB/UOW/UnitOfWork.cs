using DorksAndDice.DB.DataRepositories.CustomerDataRepositories;
using DorksAndDice.DB.DataRepositories.ProductRepositories;
using DorksAndDice.DB.DataRepositories.ProductRepositories.DiceCharacteristics;
using DorksAndDice.DB.DataRepositories.ShoppingRepositories;
using DorksAndDice.DB.DBAccess;
using DorksAndDice.DB.Interfaces.CustomerDataInterfaces;
using DorksAndDice.DB.Interfaces.DiceCharacteristicInterfaces;
using DorksAndDice.DB.Interfaces.ProductInterfaces;
using DorksAndDice.DB.Interfaces.ShoppingInterfaces;
using DorksAndDice.Logic.Models.CustomerData;
using DorksAndDice.Logic.Models.Product;
using DorksAndDice.Logic.Models.Product.DiceCharacteristics;
using DorksAndDice.Logic.Models.Shopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.UOW
{
    public class UnitOfWork
    {
        public UnitOfWork(ISqlDataAccess _db) 
        { 
            Address = new AddressRepository<Address>(_db);
            City = new CityRepository<City>(_db);
            Country = new CountryRepository<Country>(_db);
            Customer = new CustomerRepository<CustomerData>(_db);
            Dice = new DiceRepository<Dice>(_db);
            Orders = new OrdersRepository<Orders>(_db);
            ShoppingCarts = new ShoppingCartRepository<ShoppingCartItems>(_db);
            Color = new ColorRepository<Color>(_db);
            Edge = new EdgeRepository<Edge>(_db);
            Material = new MaterialRepository<Material>(_db);
            Size = new SizeRepository<Size>(_db);
            Style = new StyleRepository<Style>(_db);
            Type = new TypeRepository<Logic.Models.Product.DiceCharacteristics.Type>(_db);
        }

        public IAddressRepository<Address> Address { get; }
        public ICityRepository<City> City { get; }
        public ICountryRepository<Country> Country { get; }
        public ICustomerRepository<CustomerData> Customer { get; }
        public IDiceRepository<Dice> Dice { get; }
        public IOrdersRepository<Orders> Orders { get; }
        public IShoppingCartsRepository<ShoppingCartItems> ShoppingCarts { get; }
        public IColorRepository<Color> Color { get; }
        public IEdgeRepository<Edge> Edge { get; }
        public IMaterialRepository<Material> Material { get; }
        public ISizeRepository<Size> Size { get; }
        public IStyleRepository<Style> Style { get; }   
        public ITypeRepository<Logic.Models.Product.DiceCharacteristics.Type> Type { get; }
    }
}
