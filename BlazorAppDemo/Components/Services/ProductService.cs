
using BlazorAppDemo.Components.Models;
using System.Xml.Linq;

namespace BlazorAppDemo.Components.Services
{
    public class ProductService
    {

        private List<Product> _products = new()
        {
            new() { Id = 1, Name = "Laptop", Price = 1200 },
            new() { Id = 2, Name = "Mouse", Price = 25 }
        };

        private int _nextId = 3;

        public List<Product> GetAll() => _products;

        public Product? GetById(int id) =>
            _products.FirstOrDefault(p => p.Id == id);

        public void Add(Product product)
        {
            product.Id = _nextId++;
            _products.Add(product);
        }

        public void Update(Product updated)
        {
            var p = GetById(updated.Id);
            if (p is null) return;

            p.Name = updated.Name;
            p.Price = updated.Price;
        }

        public void Delete(int id)
        {
            var p = GetById(id);
            if (p != null)
                _products.Remove(p);
        }
    }
}
