using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        // what is Task<>?
        Task<Product> GetProductByIdAsync (int id);
        Task<IReadOnlyList<Product>> GetProductsByIdAsync();
    }
}