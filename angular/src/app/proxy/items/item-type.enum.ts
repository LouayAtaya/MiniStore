import { mapEnumToOptions } from '@abp/ng.core';

export enum ItemType {
  RawItem = 0,
  ProductItem = 1,
  AssetItem = 2,
}

export const itemTypeOptions = mapEnumToOptions(ItemType);
