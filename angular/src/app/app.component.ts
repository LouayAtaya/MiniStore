import { ReplaceableComponentsService } from '@abp/ng.core';
import { eIdentityComponents } from '@abp/ng.identity';
import { eThemeBasicComponents } from '@abp/ng.theme.basic';
import { Component } from '@angular/core';
import { HomeComponent } from './home/home.component';

@Component({
  selector: 'app-root',
  template: `
    <abp-loader-bar></abp-loader-bar>
    <abp-dynamic-layout></abp-dynamic-layout>
  `,
})
export class AppComponent {
  constructor(private replaceableComponents: ReplaceableComponentsService
  ) 
  {
    this.replaceableComponents.add({
      component: HomeComponent,
      key: eThemeBasicComponents.ApplicationLayout,
    });

  }

}
