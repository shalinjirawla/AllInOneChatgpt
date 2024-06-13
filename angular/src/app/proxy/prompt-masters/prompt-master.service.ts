import type { CreateUpdateDto, PromptMasterDto } from './models';
import { RestService, Rest } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class PromptMasterService {
  apiName = 'Default';
  

  createOrUpdate = (input: CreateUpdateDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PromptMasterDto>({
      method: 'POST',
      url: '/api/app/prompt-master',
      body: input,
    },
    { apiName: this.apiName,...config });
  

  getAll = (config?: Partial<Rest.Config>) =>
    this.restService.request<any, PromptMasterDto[]>({
      method: 'GET',
      url: '/api/app/prompt-master/get-prompt-list',
    },
    { apiName: this.apiName,...config });
  

  getById = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PromptMasterDto>({
      method: 'GET',
      url: `/api/app/prompt-master/get-async/${id}`,
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
