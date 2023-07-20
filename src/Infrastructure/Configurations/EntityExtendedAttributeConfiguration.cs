using BlazorHero.TraderWebApp.Application.Serialization.Options;
using BlazorHero.TraderWebApp.Application.Serialization.Serializers;
using BlazorHero.TraderWebApp.Domain.Contracts;
using BlazorHero.TraderWebApp.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Options;

namespace BlazorHero.TraderWebApp.Infrastructure.Configurations
{
    public class EntityExtendedAttributeConfiguration : IEntityTypeConfiguration<IEntityExtendedAttribute>
    {
        public void Configure(EntityTypeBuilder<IEntityExtendedAttribute> builder)
        {
            // This Converter will perform the conversion to and from Json to the desired type
            builder
                .Property(e => e.Json)
                .HasJsonConversion(
                    new SystemTextJsonSerializer(
                        new OptionsWrapper<SystemTextJsonOptions>(new SystemTextJsonOptions())));
        }
    }
}