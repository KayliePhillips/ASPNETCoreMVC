using ASPNETCoreMVC.Models;


namespace ASPNETCoreMVC
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
    }
}
