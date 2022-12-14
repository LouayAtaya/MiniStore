import { ConfigStateService, CurrentUserDto, ReplaceableComponentsService, SessionStateService } from '@abp/ng.core';
import { eIdentityComponents } from '@abp/ng.identity';
import { eThemeBasicComponents } from '@abp/ng.theme.basic';
import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { HomeComponent } from './home/home.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']

})
export class AppComponent {
  isCollapsed=true;
  currentUser$:Observable<CurrentUserDto>=this.configState.getOne$('currentUser');
  
  constructor(private configState:ConfigStateService,private sessionStateService: SessionStateService)
  {

    //sessionStateService.setTenant({name:'tenant1', isAvailable: true, id:"5AC706D0-9F23-DF9E-874D-3A063D863A78"})
    // this.replaceableComponents.add({
    //   component: HomeComponent,
    //   key: eThemeBasicComponents.ApplicationLayout,
    // });

  }

}
