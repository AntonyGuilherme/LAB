import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { CatracaInteligenteService } from 'src/app/services/catraca-inteligente.service';

@Component({
  selector: 'sing-up',
  templateUrl: './user-panel.component.html',
  styleUrls: ['./user-panel.component.scss']
})
export class UserPanelComponent {

  public constructor(
    private catracaInteligenteService: CatracaInteligenteService,
    private router: Router) {}

}
