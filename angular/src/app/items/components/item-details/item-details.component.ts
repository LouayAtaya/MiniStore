import { Component, Input, OnInit } from '@angular/core';
import { ItemService } from '@proxy/items';
import { NzDrawerRef } from 'ng-zorro-antd/drawer';
import { ItemDto } from '../../../proxy/items/models';

@Component({
  selector: 'app-item-details',
  templateUrl: './item-details.component.html',
  styleUrls: ['./item-details.component.scss']
})
export class ItemDetailsComponent implements OnInit {
  @Input() value;

  itemDetails: ItemDto;

  constructor(private drawerRef: NzDrawerRef<string>,  private itemService: ItemService) { }

  ngOnInit(): void {

    if(this.value){
      this.itemService.get(this.value).subscribe(
        data=>{
          this.itemDetails=data;
        },
        error=>{

        }
      )

    }
  }

}
