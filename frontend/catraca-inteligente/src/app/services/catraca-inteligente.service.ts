import { Inject, Injectable } from "@angular/core";
import { UserSingUpModel } from "../models/user-sing-up.model";
import { HttpClient } from "@angular/common/http";
import { lastValueFrom } from "rxjs";

@Injectable({ providedIn: 'root' })
export class CatracaInteligenteService {

    public constructor(public http: HttpClient) {

    }

    getUrlPath(complement: string): string {
        return '';
    }

    async singUp(model: UserSingUpModel): Promise<any> {
        console.log(model)
        return '';
        return lastValueFrom(this.http.post(this.getUrlPath('sing-up'), model));
    }
}