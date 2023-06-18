import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { UserModel } from 'src/app/models/user-sing-up.model';
import { CatracaInteligenteService } from 'src/app/services/catraca-inteligente.service';
import { UserDataProvider } from 'src/app/services/user-data-provider';

@Component({
  selector: 'sing-up',
  templateUrl: './user-panel.component.html',
  styleUrls: ['./user-panel.component.scss']
})
export class UserPanelComponent {
  model: UserModel;
  paymentModel: { token: string } = { token: ''};

  
  public constructor(
    private catracaInteligenteService: CatracaInteligenteService,
    private router: Router,
    userDataProvider: UserDataProvider) {
      this.model = userDataProvider.getUserData();
    }

    updateUser() {

    }

}
