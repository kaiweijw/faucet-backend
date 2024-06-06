using AutoMapper;
using AELFFaucet.Project;
namespace AELFFaucet
{
    public class AELFFaucetApplicationAutoMapperProfile : Profile
    {
        public AELFFaucetApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
      
            CreateMap<SendTokenInfo, SendTokenInfoDto>();
            CreateMap<SendTokenInfoDto, SendTokenInfo>();
        }
    }
}
