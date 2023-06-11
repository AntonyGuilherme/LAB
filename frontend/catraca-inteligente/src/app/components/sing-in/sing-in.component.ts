import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { UserSingInModel } from 'src/app/models/user-sing-in.model';
import { CatracaInteligenteService } from 'src/app/services/catraca-inteligente.service';

@Component({
  selector: 'sing-in',
  templateUrl: './sing-in.component.html',
  styleUrls: ['./sing-in.component.scss']
})
export class SingInComponent {
  
    model: UserSingInModel = {
        email: '',
        password: ''
    }

    public constructor(
        private catracainteligenteService: CatracaInteligenteService,
        private router: Router) {}

    singIn() {
        this.catracainteligenteService
        .singIn(this.model)
        .then((teste) => {
            console.log(teste)
            this.router.navigate(['./user-panel']);
        });
    }
}
