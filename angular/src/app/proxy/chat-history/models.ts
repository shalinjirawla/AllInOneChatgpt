import type { EntityDto } from '@abp/ng.core';

export interface CreateOrUpdate {
  id?: string;
  text?: string;
  isUser?: boolean;
  tenantId?: string;
}

export interface HistoryDto extends EntityDto<string> {
  text?: string;
  isUser: boolean;
  tenantId?: string;
}
