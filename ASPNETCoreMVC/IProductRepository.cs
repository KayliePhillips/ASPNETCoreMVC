using ASPNETCoreMVC.Models;


namespace ASPNETCoreMVC
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);

        public void UpdateProduct(Product product);

        public void InsertProduct(Product productToInsert);

        public IEnumerable<Category>GetCategories();

        public Product AssignCategory();

        public void DeleteProduct(Product productToDelete);
    }
}
