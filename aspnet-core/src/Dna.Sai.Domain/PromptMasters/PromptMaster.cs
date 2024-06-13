using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Dna.Sai.PromptMasters
{
    public class PromptMaster : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {
        public Guid? TenantId { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }

        public PromptMaster() { }

        public PromptMaster(Guid? tenantId,  string title, string content)
        {
            TenantId = tenantId;
            Title = title;
            Content = content;
        }
    }
}
