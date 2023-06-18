import { Injectable } from "@angular/core";
import { UserModel, UserSingUpModel } from "../models/user-sing-up.model";
import { HttpClient } from "@angular/common/http";
import { lastValueFrom } from "rxjs";
import { UserSingInModel } from "../models/user-sing-in.model";
import { UserDataProvider } from "./user-data-provider";

@Injectable({ providedIn: 'root' })
export class CatracaInteligenteService {
    public constructor(public http: HttpClient, private dataProvider: UserDataProvider) {

    }

    getUrlPath(complement: string = ''): string {
        return 'https://localhost:7237/api'+complement;
    }

    async singIn(model: UserSingInModel) {
        const url = this.getUrlPath("/user/singin");

        return  lastValueFrom(this.http.post(url, model))
                .then(data => this.dataProvider.setData(data));
    }

    async singUp(model: UserSingUpModel): Promise<any> {
        const url = this.getUrlPath();

        return lastValueFrom(this.http.post(url, model));
    }

    async update(model: UserModel) {
        const url = this.getUrlPath(`/${model.id}`);

        return lastValueFrom(this.http.put(url, model));
    }

    async updateToken(id: number, token: string) {
        const url = this.getUrlPath(`/payment/${id}/${token}`);

        return lastValueFrom(this.http.get(url));
    }
}