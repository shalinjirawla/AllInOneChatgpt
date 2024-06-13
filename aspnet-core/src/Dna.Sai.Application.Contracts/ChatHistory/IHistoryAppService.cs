using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Dna.Sai.ChatHistory
{
    public interface IHistoryAppService : IApplicationService
    {
        Task <HistoryDto> CreateOrUpdateAsync(CreateOrUpdate input);
        Task<List<HistoryDto>> GetAllListAsync();
    }
}
