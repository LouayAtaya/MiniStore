import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { ItemService } from '@proxy/items';
import { ItemDto } from '../proxy/items/models';

@Component({
  selector: 'app-items',
  templateUrl: './items.component.html',
  styleUrls: ['./items.component.scss'],
  providers:[ListService]
})
export class ItemsComponent implements OnInit {

  items: ItemDto[] = [];
  count = 0;

  isVisible = false;
  isOkLoading = false;


  constructor(public readonly listService: ListService, private itemService: ItemService) {}

  ngOnInit(): void {
    const bookStreamCreator = (query) => this.itemService.getList(query);

    this.listService.hookToQuery(bookStreamCreator).subscribe((response) => {
      this.items = response.items;
      this.count = response.totalCount;
    });
  }

  showModal(): void {
    this.isVisible = true;
  }

  handleOk(): void {
    this.isOkLoading = true;
    setTimeout(() => {
      this.isVisible = false;
      this.isOkLoading = false;
    }, 3000);
  }

  handleCancel(): void {
    this.isVisible = false;
  }

}
