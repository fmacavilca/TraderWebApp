﻿using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using BlazorHero.TraderWebApp.Application.Interfaces.Repositories;
using BlazorHero.TraderWebApp.Application.Interfaces.Services.Storage;
using BlazorHero.TraderWebApp.Application.Interfaces.Services.Storage.Provider;
using BlazorHero.TraderWebApp.Application.Interfaces.Serialization.Serializers;
using BlazorHero.TraderWebApp.Application.Serialization.JsonConverters;
using BlazorHero.TraderWebApp.Infrastructure.Repositories;
using BlazorHero.TraderWebApp.Infrastructure.Services.Storage;
using BlazorHero.TraderWebApp.Application.Serialization.Options;
using BlazorHero.TraderWebApp.Infrastructure.Services.Storage.Provider;
using BlazorHero.TraderWebApp.Application.Serialization.Serializers;

namespace BlazorHero.TraderWebApp.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructureMappings(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddTransient(typeof(IRepositoryAsync<,>), typeof(RepositoryAsync<,>))
                .AddTransient<IProductRepository, ProductRepository>()
                .AddTransient<IBrandRepository, BrandRepository>()
                .AddTransient<IDocumentRepository, DocumentRepository>()
                .AddTransient<IDocumentTypeRepository, DocumentTypeRepository>()
                .AddTransient(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
        }

        public static IServiceCollection AddExtendedAttributesUnitOfWork(this IServiceCollection services)
        {
            return services
                .AddTransient(typeof(IExtendedAttributeUnitOfWork<,,>), typeof(ExtendedAttributeUnitOfWork<,,>));
        }

        public static IServiceCollection AddServerStorage(this IServiceCollection services)
            => AddServerStorage(services, null);

        public static IServiceCollection AddServerStorage(this IServiceCollection services, Action<SystemTextJsonOptions> configure)
        {
            return services
                .AddScoped<IJsonSerializer, SystemTextJsonSerializer>()
                .AddScoped<IStorageProvider, ServerStorageProvider>()
                .AddScoped<IServerStorageService, ServerStorageService>()
                .AddScoped<ISyncServerStorageService, ServerStorageService>()
                .Configure<SystemTextJsonOptions>(configureOptions =>
                {
                    configure?.Invoke(configureOptions);
                    if (!configureOptions.JsonSerializerOptions.Converters.Any(c => c.GetType() == typeof(TimespanJsonConverter)))
                        configureOptions.JsonSerializerOptions.Converters.Add(new TimespanJsonConverter());
                });
        }
    }
}