using BlazorHero.TraderWebApp.Application.Specifications.Base;
using BlazorHero.TraderWebApp.Domain.Entities.Catalog;

namespace BlazorHero.TraderWebApp.Application.Specifications.Catalog
{
    public class BrandFilterSpecification : HeroSpecification<Brand>
    {
        public BrandFilterSpecification(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                Criteria = p => p.Name.Contains(searchString) || p.Description.Contains(searchString);
            }
            else
            {
                Criteria = p => true;
            }
        }
    }
}
