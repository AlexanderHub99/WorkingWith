namespace WorkingWith.Models
{
    public class SimpleRepository
    {
        public static SimpleRepository ShardRepositiry { get; } = new SimpleRepository();
        private readonly Dictionary<string, Product> _products = new Dictionary<string, Product>();

        private SimpleRepository()
        {
            var init = new[]
            {
                new Product {Name = "Kayak", Price = 234.95M},
                new Product {Name = "KayakSimpl", Price = 634.75M},
                new Product {Name = "KayakHard", Price = 334.43M},
                new Product {Name = "KayakLou", Price = 734.55M},
            };
            foreach (Product product in init)
            {
                AddProduct(product);
            }
        }

        public IEnumerable<Product> Products => _products.Values;
        private void AddProduct(Product product) => _products.Add(product.Name, product);
    }
}

