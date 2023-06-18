import { Inject, Injectable } from "@angular/core";
import { UserSingUpModel } from "../models/user-sing-up.model";
import { HttpClient } from "@angular/common/http";
import { lastValueFrom } from "rxjs";
import { UserSingInModel } from "../models/user-sing-in.model";

@Injectable({ providedIn: 'root' })
export class CatracaInteligenteService {

    public constructor(public http: HttpClient) {

    }

    getUrlPath(complement?: string): string {
        return 'https://localhost:7237/api';
    }

    async singIn(model: UserSingInModel) {
        const url = this.getUrlPath();

        return lastValueFrom(this.http.post(url, model));
    }

    async singUp(model: UserSingUpModel): Promise<any> {
        
        const url = this.getUrlPath();

        return lastValueFrom(this.http.post(url, model));
    }
}