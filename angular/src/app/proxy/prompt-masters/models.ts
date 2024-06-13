import type { EntityDto } from '@abp/ng.core';

export interface CreateUpdateDto {
  id?: string;
  tenantId?: string;
  title?: string;
  content?: string;
}

export interface PromptMasterDto extends EntityDto<string> {
  tenantId?: string;
  title?: string;
  content?: string;
}
