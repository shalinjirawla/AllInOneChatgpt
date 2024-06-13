using AutoMapper;
using Dna.Sai.ChatHistory;
using Dna.Sai.PromptMasters;

namespace Dna.Sai;

public class SaiApplicationAutoMapperProfile : Profile
{
    public SaiApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<PromptMaster, CreateUpdateDto>().ReverseMap();
        CreateMap<PromptMaster, PromptMasterDto>().ReverseMap();
        CreateMap<History, HistoryDto>().ReverseMap();
        CreateMap<History,CreateOrUpdate>().ReverseMap();
    }
}
