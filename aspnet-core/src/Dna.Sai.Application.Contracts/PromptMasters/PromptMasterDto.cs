using System;
using Volo.Abp.Application.Dtos;

namespace Dna.Sai.PromptMasters
{
    public class PromptMasterDto : EntityDto<Guid>
    {
        public Guid? TenantId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
    }
}
