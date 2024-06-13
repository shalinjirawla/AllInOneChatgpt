using Dna.Sai.Chatgpt;
using Dna.Sai.PromptMasters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;

namespace Dna.Sai.Controllers.PromptMasters
{
    [RemoteService]
    [Area("app")]
    [ControllerName("PromptMaster")]
    [Route("api/app/prompt-master")]
    public class PromptMasterController : AbpController, IPromptMasterAppService
    {
        private readonly IPromptMasterAppService _iPromptMasterAppService;
        public PromptMasterController(IPromptMasterAppService iPromptMasterAppService)
        {
            _iPromptMasterAppService = iPromptMasterAppService;
        }
        [HttpPost]
        public Task<PromptMasterDto> CreateOrUpdateAsync(CreateUpdateDto input)
        {
            return _iPromptMasterAppService.CreateOrUpdateAsync(input);
        }

        [HttpGet]
        [Route("get-prompt-list")]
        public Task<List<PromptMasterDto>> GetAllAsync()
        {
            return _iPromptMasterAppService.GetAllAsync();
        }

        [HttpGet]
        [Route("get-async/{id}")]
        public Task<PromptMasterDto> GetByIdAsync(Guid id)
        {
            return _iPromptMasterAppService.GetByIdAsync(id);
        }
    }
}
