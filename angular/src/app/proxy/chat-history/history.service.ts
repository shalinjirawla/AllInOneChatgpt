import type { CreateOrUpdate, HistoryDto } from './models';
import { RestService, Rest } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class HistoryService {
  apiName = 'Default';
  

  createOrUpdate = (input: CreateOrUpdate, config?: Partial<Rest.Config>) =>
    this.restService.request<any, HistoryDto>({
      method: 'POST',
      url: '/api/app/history/or-update',
      body: input,
    },
    { apiName: this.apiName,...config });
  

  getAllList = (config?: Partial<Rest.Config>) =>
    this.restService.request<any, HistoryDto[]>({
      method: 'GET',
      url: '/api/app/history/list',
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
