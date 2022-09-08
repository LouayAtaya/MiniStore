import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ItemForCreationDto, itemTypeOptions } from '@proxy/items';
import { NzModalRef } from 'ng-zorro-antd/modal';
import { NotEmpty } from 'src/app/shared/validators/not-empty.validator';
import { ItemService } from '../../../proxy/items/item.service';

@Component({
  selector: 'app-item-form',
  templateUrl: './item-form.component.html',
  styleUrls: ['./item-form.component.scss']
})
export class ItemFormComponent implements OnInit {

  itemForm: FormGroup;

  itemForCreationDto:ItemForCreationDto;

  // add itemTypes as a list of ItemType enum members
  itemTypes = itemTypeOptions;

  constructor(private modal: NzModalRef, private itemService:ItemService, private formBuilder:FormBuilder) { }

  ngOnInit(): void {
    this.itemForm= this.formBuilder.group({
      code:['',[Validators.required, Validators.minLength(2), Validators.maxLength(5), NotEmpty]],
      name: ['',[Validators.required, Validators.minLength(4), Validators.maxLength(50), NotEmpty]],
      description:['',[Validators.maxLength(500)]],
      price:[null,Validators.required],
      totalQuantity:[null,Validators.required],
      type:[null,[Validators.required]],
      publishDate:[null,[Validators.required]],
    })
  }

  submitForm(){

    if (this.itemForm.invalid) {
      return;
    }

    this.itemForCreationDto=this.itemForm.value;

    this.itemService.createWithFeatureCheckByItemForCreationDto(this.itemForCreationDto).subscribe(
      data=>{
        this.modal.destroy({success:true})
        this.itemForm.reset();
      },
      error=>{

      }
      
    )

  }

  closeModal(): void {
    this.modal.triggerCancel();

  }



}
