import type { AuditedEntityDto } from '@abp/ng.core';
import type { ItemType } from './item-type.enum';

export interface ItemDto extends AuditedEntityDto<string> {
  code?: string;
  name?: string;
  description?: string;
  price: number;
  totalQuantity: number;
  type: ItemType;
  publishDate?: string;
}

export interface ItemForCreationDto {
  code: string;
  name: string;
  description?: string;
  price: number;
  totalQuantity: number;
  type: ItemType;
  publishDate: string;
}

export interface ItemForUpdateDto {
  code: string;
  name: string;
  description?: string;
  price: number;
  totalQuantity: number;
  type: ItemType;
  publishDate: string;
}
