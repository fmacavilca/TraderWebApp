using BlazorHero.TraderWebApp.Application.Specifications.Base;
using BlazorHero.TraderWebApp.Domain.Entities.Misc;

namespace BlazorHero.TraderWebApp.Application.Specifications.Misc
{
    public class DocumentTypeFilterSpecification : HeroSpecification<DocumentType>
    {
        public DocumentTypeFilterSpecification(string searchString)
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