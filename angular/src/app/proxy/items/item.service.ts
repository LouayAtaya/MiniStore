import type { ItemDto, ItemForCreationDto, ItemForUpdateDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class ItemService {
  apiName = 'Default';

  create = (input: ItemForCreationDto) =>
    this.restService.request<any, ItemDto>({
      method: 'POST',
      url: '/api/app/item',
      body: input,
    },
    { apiName: this.apiName });

  createWithFeatureCheckByItemForCreationDto = (itemForCreationDto: ItemForCreationDto) =>
    this.restService.request<any, ItemDto>({
      method: 'POST',
      url: '/api/app/item/with-feature-check',
      body: itemForCreationDto,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/item/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, ItemDto>({
      method: 'GET',
      url: `/api/app/item/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<ItemDto>>({
      method: 'GET',
      url: '/api/app/item',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  update = (id: string, input: ItemForUpdateDto) =>
    this.restService.request<any, ItemDto>({
      method: 'PUT',
      url: `/api/app/item/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
