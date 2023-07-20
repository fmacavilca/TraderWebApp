using BlazorHero.TraderWebApp.Application.Interfaces.Repositories;
using BlazorHero.TraderWebApp.Domain.Entities.Catalog;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BlazorHero.TraderWebApp.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IRepositoryAsync<Product, int> _repository;

        public ProductRepository(IRepositoryAsync<Product, int> repository)
        {
            _repository = repository;
        }

        public async Task<bool> IsBrandUsed(int brandId)
        {
            return await _repository.Entities.AnyAsync(b => b.BrandId == brandId);
        }
    }
}