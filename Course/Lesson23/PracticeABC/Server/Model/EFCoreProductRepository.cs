public class EFCoreProductRepository : IProductReposytory
{
    private readonly ProductContext _context;

    public EFCoreProductRepository(ProductContext context)
    {
        _context = context;
    }

    public List<Product> GetAllProducts()
    {
        return _context.Products.ToList();
    }

    public EFCoreProductRepository GetProductByName(string name)
    {
        return _context.Products.FirstOrDefault(p => p.Name == name);
    }

    public void AddProduct(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
    }
    public void UpdateProduct(Product product)
    {
        _context.Products.Update(product);
        _context.SaveChanges();
    }

    public void DeleteProduct(string name)
    {
        var product = _context.Products.FirstOrDefault(product => product.Name == name);

        if(product != null)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
    }
}