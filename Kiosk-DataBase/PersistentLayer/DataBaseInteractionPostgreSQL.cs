using System.Collections.Generic;
using Kiosk_DataBase.Models;

namespace Kiosk_DataBase.PersistentLayer
{
    public class DataBaseInteractionPostgreSQL
    {
        private List<Product> _products;
        
        public Product[] GetAllProducts()
        {
            for (int i = 0; i < _products.Count; i++)
            {
                _products[i].Id = i;
            }
            
            return _products.ToArray();
        }

        public void AddProduct(Product productToAdd)
        {
            _products.Add(productToAdd);
        }

        public DataBaseInteractionPostgreSQL()
        {
            _products = new List<Product>();
            
            var product = new Product
            {
                Name = "Комсомольская правда",
                Price = 100,
                Producer = "Издательство \"Кок\"",
                Author = "Антон Гришков",
                Count = 5,
                Type = "Газета"
            };

            var product2 = new Product
            {
                Name = "Синтетическая правда",
                Price = 150,
                Producer = "Издательство \"Кок\"",
                Author = "Влад Петров",
                Count = 2,
                Type = "Газета"
            };

            _products.Add(product);
            _products.Add(product2);
        }

        public Product GetProductById(int id)
        {
            return _products[id];
        }

        public void UpdateProduct(Product updatedProduct)
        {
            _products[updatedProduct.Id] = updatedProduct;
        }

        public void DeleteProduct(int id)
        {
            var foundProductToRemove = _products[id];
            _products.Remove(foundProductToRemove);
        }
    }
}