using AutoMapper;
using DomainLayer.Models.ProductModule;
using Microsoft.Extensions.Configuration;
using Shared.DataTransferObjects.ProductModuleDTOs;

namespace Services.MappingProfiles
{
    public class PictureUrlResolver : IValueResolver<Product, ProductDTO, string>
    {
        private readonly IConfiguration _configuration;
        public PictureUrlResolver(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Resolve(Product source, ProductDTO destination, string destMember, ResolutionContext context)
        {
            if (string.IsNullOrEmpty(source.PictureUrl))
                return string.Empty;

            if (Uri.TryCreate(source.PictureUrl, UriKind.Absolute, out _))
                return source.PictureUrl;

            var baseUrl = _configuration.GetSection("Urls")["BaseUrl"];

            var relativePath = source.PictureUrl.TrimStart('/');
            return $"{baseUrl.TrimEnd('/')}/{relativePath}";
        }
    }
}