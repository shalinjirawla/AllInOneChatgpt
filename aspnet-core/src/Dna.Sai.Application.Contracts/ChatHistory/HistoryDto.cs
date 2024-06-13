using System;
using Volo.Abp.Application.Dtos;

namespace Dna.Sai.ChatHistory
{
    public class HistoryDto : EntityDto<Guid>
    {
        public string Text { get; set; }
        public bool IsUser { get; set; }
        public Guid? TenantId { get; set; }
    }
}
