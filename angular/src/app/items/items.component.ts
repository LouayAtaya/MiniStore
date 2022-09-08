import { ListService, LocalizationService, PagedResultDto, SessionStateService } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { ItemService } from '@proxy/items';
import { NzDrawerService } from 'ng-zorro-antd/drawer';
import { NzMessageService } from 'ng-zorro-antd/message';
import { NzModalService } from 'ng-zorro-antd/modal';
import { ItemDto } from '../proxy/items/models';
import { ItemDetailsComponent } from './components/item-details/item-details.component';
import { ItemFormComponent } from './components/item-form/item-form.component';

@Component({
  selector: 'app-items',
  templateUrl: './items.component.html',
  styleUrls: ['./items.component.scss'],
  providers:[ListService]
})
export class ItemsComponent implements OnInit {

  items: ItemDto[] = [];
  count = 0;



  constructor(public readonly listService: ListService, private itemService: ItemService, private modalService: NzModalService, public drawerService:NzDrawerService,     private sessionState: SessionStateService, private localizationService: LocalizationService, private messageService: NzMessageService
    ) {}

  ngOnInit(): void {
    const bookStreamCreator = (query) => this.itemService.getList(query);

    this.listService.hookToQuery(bookStreamCreator).subscribe((response) => {
      this.items = response.items;
      this.count = response.totalCount;
    });
  }

  addNewItem(): void {
    let modal=this.modalService.create({
      nzTitle: this.localizationService.instant('::NewItem'),
      nzWidth:"600px",
      nzContent: ItemFormComponent,
      nzOnOk: () =>{ console.log("okkkkk"); new Promise(resolve => setTimeout(resolve, 1000))},

    });  

    modal.afterClose.subscribe(
      result => {
        if(result&& result.success){
          this.messageService.create("success",this.localizationService.instant('::NewItemAdded'))
          this.listService.get();
        }

      }
    );


  }

  openDetailsDrawer(itemId){
    const drawerRef = this.drawerService.create<ItemDetailsComponent, { value: string }, string>({
      nzTitle: this.localizationService.instant('::ItemDetails'),
      nzPlacement: this.selectedLangCulture=='ar'?'left':'right',
      nzContent: ItemDetailsComponent,
      nzContentParams: {
        value: itemId
      }
    });

  }

  deleteItem(itemId){
    this.modalService.confirm({
      nzTitle: this.localizationService.instant('::AreYouSureToDelete'),
      nzOnOk: () =>{
        this.itemService.delete(itemId).subscribe(
          () => {
            this.listService.get()
            this.messageService.create("success",this.localizationService.instant('::ItemDeleted'))
          }
        )

      }

    });
  }

  get selectedLangCulture(): string {
    
    return this.sessionState.getLanguage();
  }

  

  

}
