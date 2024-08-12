using ProductTestApi.Domain;

namespace ProductTestApi.Interfaces
{
    public interface IProduct
    {
        public void Cadastrar(Product product);

        public List<Product> Listar();

        public Product ListarPorId(Guid id);

        public void Deletar(Guid id);

        public void AtualizarProduto(Product products);
    }
}
