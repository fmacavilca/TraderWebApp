using BlazorHero.TraderWebApp.Domain.Entities.ExtendedAttributes;
using BlazorHero.TraderWebApp.Domain.Entities.Misc;
using Microsoft.Extensions.Localization;

namespace BlazorHero.TraderWebApp.Application.Validators.Features.ExtendedAttributes.Commands.AddEdit
{
    public class AddEditDocumentExtendedAttributeCommandValidator : AddEditExtendedAttributeCommandValidator<int, int, Document, DocumentExtendedAttribute>
    {
        public AddEditDocumentExtendedAttributeCommandValidator(IStringLocalizer<AddEditExtendedAttributeCommandValidatorLocalization> localizer) : base(localizer)
        {
            // you can override the validation rules here
        }
    }
}