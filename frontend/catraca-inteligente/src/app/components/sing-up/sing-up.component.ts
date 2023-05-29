import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { UserSingUpModel } from 'src/app/models/user-sing-up.model';
import { CatracaInteligenteService } from 'src/app/services/catraca-inteligente.service';

@Component({
  selector: 'sing-up',
  templateUrl: './sing-up.component.html',
  styleUrls: ['./sing-up.component.scss']
})
export class SingUpComponent {
  
model: UserSingUpModel = {
  name: '',
  email: '',
  ufmgEnrollment: '',
  password: '',
};

  public constructor(
    private catracaInteligenteService: CatracaInteligenteService,
    private router: Router) {}


  singUp() {
      this.catracaInteligenteService
      .singUp(this.model)
      .then(() => this.router.navigate(['./sing-in']));
  }

}
