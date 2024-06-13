using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Dna.Sai.Chatgpt;

namespace Dna.Sai.PromptMasters
{
    [RemoteService(IsEnabled = false)]
    public class PromptMasterAppService : ApplicationService, IPromptMasterAppService
    {
        private readonly IRepository<PromptMaster, Guid> _promptMasterService;

        public PromptMasterAppService(IRepository<PromptMaster, Guid> promptMasterService)
        {
            _promptMasterService = promptMasterService;
        }
        public async Task<PromptMasterDto> CreateOrUpdateAsync(CreateUpdateDto input)
        {
            try
            {
                PromptMaster promptMaster = new PromptMaster();
                promptMaster = ObjectMapper.Map<CreateUpdateDto, PromptMaster>(input);
                promptMaster.TenantId = CurrentTenant.Id;
                if (promptMaster.Id != null && promptMaster.Id != Guid.Empty)
                {
                    promptMaster = await _promptMasterService.FirstOrDefaultAsync(x => x.Id == promptMaster.Id);
                    promptMaster = ObjectMapper.Map(input,promptMaster);
                    promptMaster = await _promptMasterService.UpdateAsync(promptMaster, true);
                }
                else
                    promptMaster = await _promptMasterService.InsertAsync(promptMaster, true);
                await UnitOfWorkManager.Current.SaveChangesAsync();
                return ObjectMapper.Map<PromptMaster, PromptMasterDto>(promptMaster);
            }
            catch (Exception ex)
            {
                throw new UserFriendlyException(ex.Message);
            }
        }

        public async Task<List<PromptMasterDto>> GetAllAsync()
        {
            var data = await _promptMasterService.GetListAsync();
            return ObjectMapper.Map<List<PromptMaster>, List<PromptMasterDto>>(data); ;
        }

        public async Task<PromptMasterDto> GetByIdAsync(Guid id)
        {
            var data = await _promptMasterService.FirstOrDefaultAsync(x => x.Id == id);
            if (data == null)
            {
                return new PromptMasterDto();
            }
            return ObjectMapper.Map<PromptMaster, PromptMasterDto>(data);
        }

    }
}
