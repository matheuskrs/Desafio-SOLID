using SOLID.DIP.Solucao.Interfaces;

namespace SOLID.DIP.Solucao.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        /*
          Agora, dependemos da abstração do repositório, não de uma implementação concreta.
         */


        public object CreateProduct(string product)
        {
            return _productRepository.CreateProduct(product);
        }
    }
}
