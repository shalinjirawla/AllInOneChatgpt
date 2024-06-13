using System;

namespace Dna.Sai.ChatHistory
{
    public class CreateOrUpdate
    {
        public string? Id {  get; set; }
        public string Text { get; set; }
        public bool? IsUser { get; set; }
        public Guid? TenantId { get; set; }
    }
}
