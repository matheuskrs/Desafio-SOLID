using SOLID.DIP.Violacao.Repositories;
namespace SOLID.DIP.Violacao.Services
{
    public class ProductService
    {
        public string CreateProduct(string produto)
        {
            return new ProductRepository().CreateProduct(produto);
        }
    }
}
