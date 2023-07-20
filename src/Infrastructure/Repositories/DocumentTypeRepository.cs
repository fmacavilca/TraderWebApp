using BlazorHero.TraderWebApp.Application.Interfaces.Repositories;
using BlazorHero.TraderWebApp.Domain.Entities.Misc;

namespace BlazorHero.TraderWebApp.Infrastructure.Repositories
{
    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly IRepositoryAsync<DocumentType, int> _repository;

        public DocumentTypeRepository(IRepositoryAsync<DocumentType, int> repository)
        {
            _repository = repository;
        }
    }
}