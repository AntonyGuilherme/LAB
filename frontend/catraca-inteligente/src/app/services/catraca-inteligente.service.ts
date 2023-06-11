import { Inject, Injectable } from "@angular/core";
import { UserSingUpModel } from "../models/user-sing-up.model";
import { HttpClient } from "@angular/common/http";
import { lastValueFrom } from "rxjs";
import { UserSingInModel } from "../models/user-sing-in.model";

@Injectable({ providedIn: 'root' })
export class CatracaInteligenteService {

    public constructor(public http: HttpClient) { }

    getUrlPath(complement: string): string {
        return `http://localhost:5115/CratracaInteligente/${complement}`;
    }

    async singIn(model: UserSingInModel) {
        const url = this.getUrlPath(`SingIn?email=${model.email}&password=${model.password}`);

        return lastValueFrom(this.http.get(url));
    }

    async singUp(model: UserSingUpModel): Promise<any> {
        return lastValueFrom(this.http.post(this.getUrlPath('SingUp'), model));
    }

    async toggleCardUsability(userId: number) {
        const url = this.getUrlPath(`ToggleCardUsability`);

        return lastValueFrom(this.http.patch(url, { userId }));
    }

    async insertPaymentToken(userId: number, paymentToken: string) {
        return lastValueFrom(this.http.put(this.getUrlPath("InsertPaymentToken"), { userId, paymentToken }));
    }
}