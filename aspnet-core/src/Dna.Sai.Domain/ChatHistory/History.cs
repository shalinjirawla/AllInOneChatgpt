using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Dna.Sai.ChatHistory
{
    public class History : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {
        public string Text { get; set; }
        public bool IsUser {  get; set; }
        public Guid? TenantId { get; set; }
        public History() { }
        public History( string text , bool isUser ) {
            Text = text;    
            IsUser = isUser;
        }

    }
}
