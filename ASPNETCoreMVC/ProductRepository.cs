using ASPNETCoreMVC.Models;
using Dapper;
using System.Data;


namespace ASPNETCoreMVC
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;
        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        
        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM Products;");
        }
                
        public Product GetProduct(int id)
        {
            return _conn.QuerySingle<Product>("SELECT * FROM Products WHERE ProductID = @id ;", new {id = id});
        }

        public void UpdateProduct(Product product)
        {
            _conn.Execute("UPDATE products SET Name=@Name, Price=@Price WHERE ProductID = @id;",
                new {name=product.Name, price = product.Price, id = product.ProductID});
        }

        public void InsertProduct(Product productToInsert)
        {
            _conn.Execute("INSERT INTO Products (Name, Price, CategoryID) VALUES (@name, @price, @categoryID);",
                new { name = productToInsert.Name, price = productToInsert.Price, categoryID = productToInsert.CategoryID });
               
        }

        public IEnumerable<Category> GetCategories()
        {
            return _conn.Query<Category>("SELECT * FROM Categories;");
        }
        public Product AssignCategory()
        {
           var categoryList = GetCategories();
            var product = new Product();
            product.Categories = categoryList;
            return product;
        }

    }
}
