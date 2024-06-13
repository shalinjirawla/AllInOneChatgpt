using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dna.Sai.ChatHistory
{
    public class HistoryAppService : ApplicationService, IHistoryAppService
    {
        private readonly IRepository<History, Guid> _historyService;

        public HistoryAppService(IRepository<History, Guid> historyService)
        {
            _historyService = historyService;
        }
        public async Task<HistoryDto> CreateOrUpdateAsync(CreateOrUpdate input)
        {
            try
            {
                History history = new History();
                history = ObjectMapper.Map<CreateOrUpdate, History>(input);
                history.TenantId = CurrentTenant.Id;
                
                if (history.Id != null && history.Id != Guid.Empty)
                {
                    history = await _historyService.FirstOrDefaultAsync(x => x.Id == history.Id);
                    history = ObjectMapper.Map(input, history);
                    history = await _historyService.UpdateAsync(history, true);
                }
                else
                    history = await _historyService.InsertAsync(history, true);
                await UnitOfWorkManager.Current.SaveChangesAsync();
                return ObjectMapper.Map<History, HistoryDto>(history);
            }
            catch (Exception ex)
            {
                throw new UserFriendlyException(ex.Message);
            }

        }
        public async Task<List<HistoryDto>> GetAllListAsync()
        {
            try
            {
                var data = await _historyService.GetListAsync();
                return ObjectMapper.Map<List<History>, List<HistoryDto>>(data);
            }
            catch (Exception ex)
            {
                throw new UserFriendlyException(ex.Message);
            }
        }

    }
}
