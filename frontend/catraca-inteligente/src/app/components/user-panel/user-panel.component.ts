import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { UserSingUpModel } from 'src/app/models/user-sing-up.model';
import { CatracaInteligenteService } from 'src/app/services/catraca-inteligente.service';

@Component({
  selector: 'sing-up',
  templateUrl: './user-panel.component.html',
  styleUrls: ['./user-panel.component.scss']
})
export class UserPanelComponent {

  model: UserSingUpModel = {
    name: '',
    email: '',
    ufmgEnrollment: '',
    password: '',
  };

  public constructor(
    private catracaInteligenteService: CatracaInteligenteService,
    private router: Router) {}

    updateUser() {

    }

}
