import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NbButtonModule, NbCardModule, NbInputModule, NbLayoutModule, NbSidebarModule, NbStatusService, NbTabsetModule, NbThemeModule, NbThemeService, NbToastrModule } from '@nebular/theme';
import { SingUpComponent } from './components/sing-up/sing-up.component';
import { SingInComponent } from './components/sing-in/sing-in.component';
import { FormsModule } from '@angular/forms';
import { UserPanelComponent } from './components/user-panel/user-panel.component';

@NgModule({
  declarations: [
    AppComponent,
    SingUpComponent,
    SingInComponent,
    UserPanelComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NbButtonModule,
    NbLayoutModule,
    NbInputModule,
    NbCardModule,
    NbSidebarModule.forRoot(),
    NbThemeModule.forRoot(),
    HttpClientModule,
    FormsModule,
    NbTabsetModule,
    NbToastrModule.forRoot({ limit: 500, duration: 500, destroyByClick: true }),
  ],
  providers: [
    NbStatusService, 
    NbThemeService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
