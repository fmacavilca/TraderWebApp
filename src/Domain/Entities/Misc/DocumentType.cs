using BlazorHero.TraderWebApp.Domain.Contracts;

namespace BlazorHero.TraderWebApp.Domain.Entities.Misc
{
    public class DocumentType : AuditableEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}