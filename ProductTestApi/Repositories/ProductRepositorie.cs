using Microsoft.AspNetCore.Http.HttpResults;
using ProductTestApi.Contexts;
using ProductTestApi.Domain;
using ProductTestApi.Interfaces;

namespace ProductTestApi.Repositories
{
    public class ProductRepositorie : IProduct
    {

        public ProductContext ctx = new ProductContext();

        public void AtualizarProduto(Product product)
        {
           Product produtoEncontrado = ctx.Products.Find(product.IdProduct)!;

            produtoEncontrado.IdProduct = product.IdProduct;
            produtoEncontrado.NameProduct = product.NameProduct;
            produtoEncontrado.PriceProduct = product.PriceProduct;

            ctx.Update(produtoEncontrado);

            ctx.SaveChanges();
        }

        public void Cadastrar(Product product)
        {
            ctx.Products.Add(product);
            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            var produtoEncontrado = ctx.Products.Find(id);

            ctx.Products.Remove(produtoEncontrado!);
            ctx.SaveChanges();
        }

        public List<Product> Listar()
        {
            return ctx.Products.
                Select(p => new Product
                {
                    IdProduct = p.IdProduct,
                    NameProduct = p.NameProduct,
                    PriceProduct = p.PriceProduct
                }).ToList();
        }

        public Product ListarPorId(Guid id)
        {
            return ctx.Products
                .Select(p => new Product
                {
                    IdProduct = p.IdProduct,
                    NameProduct = p.NameProduct,
                    PriceProduct = p.PriceProduct
                })
                .FirstOrDefault(p => p.IdProduct == id)!;
        }
    }
}
