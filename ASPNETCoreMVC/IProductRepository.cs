using ASPNETCoreMVC.Models;


namespace ASPNETCoreMVC
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
