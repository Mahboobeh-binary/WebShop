using AutoMapper;
using AutoMapper.Configuration;

namespace AutoMapperContracts
{
    public interface IHaveCustomMappings
    {
        void CreateMappings(IConfiguration configuration);
    }
}
