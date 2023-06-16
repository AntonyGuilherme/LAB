import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NbToastrService } from '@nebular/theme';
import { UserModel } from 'src/app/models/user-sing-up.model';
import { CatracaInteligenteService } from 'src/app/services/catraca-inteligente.service';

@Component({
  selector: 'sing-up',
  templateUrl: './user-panel.component.html',
  styleUrls: ['./user-panel.component.scss']
})
export class UserPanelComponent implements OnInit {

  model: UserModel = {
    name: '',
    email: '',
    enrollNumber: '',
    paymentToken: '',
    cardId: '',
    id: 0,
    fump: '',
    isActive: false
  };

  paymentModel: { token: string } = { token: '' };


  public constructor(
    private catracaInteligenteService: CatracaInteligenteService,
    private router: Router,
    private toast: NbToastrService) {
    this.model = JSON.parse(<string>localStorage.getItem("user-data"));
  }

  ngOnInit(): void {}

  async updatePaymentToken() {
    return this.catracaInteligenteService
      .insertPaymentToken(this.model.id, this.model.paymentToken);
  }

}
