using Ecom.Repository.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecom.Business.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsAsync();
    }
}