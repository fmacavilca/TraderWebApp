using System.Threading.Tasks;

namespace BlazorHero.TraderWebApp.Application.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<bool> IsBrandUsed(int brandId);
    }
}