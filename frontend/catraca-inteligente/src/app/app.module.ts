import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NbButtonModule, NbCardModule, NbInputModule, NbLayoutModule, NbSidebarModule, NbStatusService, NbThemeModule, NbThemeService } from '@nebular/theme';
import { SingUpComponent } from './components/sing-up/sing-up.component';
import { SingInComponent } from './components/sing-in/sing-in.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    SingUpComponent,
    SingInComponent
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
    FormsModule
  ],
  providers: [
    NbStatusService, 
    NbThemeService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
