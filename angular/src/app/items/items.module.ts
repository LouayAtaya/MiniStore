import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ItemsRoutingModule } from './items-routing.module';
import { ItemsComponent } from './items.component';
import { SharedModule } from '../shared';


@NgModule({
  declarations: [
    ItemsComponent
  ],
  imports: [
    CommonModule,
    ItemsRoutingModule,
    SharedModule
  ]
})
export class ItemsModule { }
