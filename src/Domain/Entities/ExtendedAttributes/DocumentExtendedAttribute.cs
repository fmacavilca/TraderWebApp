using BlazorHero.TraderWebApp.Domain.Contracts;
using BlazorHero.TraderWebApp.Domain.Entities.Misc;

namespace BlazorHero.TraderWebApp.Domain.Entities.ExtendedAttributes
{
    public class DocumentExtendedAttribute : AuditableEntityExtendedAttribute<int, int, Document>
    {
    }
}