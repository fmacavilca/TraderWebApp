using BlazorHero.TraderWebApp.Application.Interfaces.Repositories;
using BlazorHero.TraderWebApp.Domain.Entities.Catalog;

namespace BlazorHero.TraderWebApp.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IRepositoryAsync<Brand, int> _repository;

        public BrandRepository(IRepositoryAsync<Brand, int> repository)
        {
            _repository = repository;
        }
    }
}