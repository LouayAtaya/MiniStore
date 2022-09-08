import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ItemsRoutingModule } from './items-routing.module';
import { ItemsComponent } from './items.component';
import { SharedModule } from '../shared';
import { ItemFormComponent } from './components/item-form/item-form.component';
import { ItemDetailsComponent } from './components/item-details/item-details.component';


@NgModule({
  declarations: [
    ItemsComponent,
    ItemFormComponent,
    ItemDetailsComponent
  ],
  imports: [
    CommonModule,
    ItemsRoutingModule,
    SharedModule
  ]
})
export class ItemsModule { }
