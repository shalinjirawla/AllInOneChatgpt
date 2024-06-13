using System;

namespace Dna.Sai.PromptMasters
{
    public class CreateUpdateDto
    {
        public string? Id { get; set; }
        public Guid? TenantId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
