using Dna.Sai.PromptMasters;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Dna.Sai.Chatgpt
{
    public interface IPromptMasterAppService : IApplicationService
    {
        Task<PromptMasterDto> CreateOrUpdateAsync(CreateUpdateDto input);
        Task<List<PromptMasterDto>> GetAllAsync();
        Task<PromptMasterDto> GetByIdAsync(Guid id);
    }
}
