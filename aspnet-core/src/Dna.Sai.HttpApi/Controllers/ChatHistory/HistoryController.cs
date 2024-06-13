using Dna.Sai.ChatHistory;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;

namespace Dna.Sai.Controllers.ChatHistory
{
    [RemoteService]
    [Area("app")]
    [ControllerName("ChatHistory")]
    [Route("api/app/chat-history")]
    public class HistoryController : AbpController ,IHistoryAppService
    {
        private readonly IHistoryAppService _iHistoryAppService;
        public HistoryController(IHistoryAppService iHistoryAppService)
        {
           _iHistoryAppService = iHistoryAppService;
        }
        [HttpPost]
        public Task<HistoryDto> CreateOrUpdateAsync(CreateOrUpdate input)
        {
            return _iHistoryAppService.CreateOrUpdateAsync(input);
        }
        [HttpGet]
        [Route("get-chathistory-list")]
        public Task<List<HistoryDto>> GetAllListAsync()
        {
            return _iHistoryAppService.GetAllListAsync();
        }
    }
}
