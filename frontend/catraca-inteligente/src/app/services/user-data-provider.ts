import { Inject, Injectable } from "@angular/core";
import { UserModel, UserSingUpModel } from "../models/user-sing-up.model";
import { HttpClient } from "@angular/common/http";
import { lastValueFrom } from "rxjs";
import { UserSingInModel } from "../models/user-sing-in.model";

@Injectable({ providedIn: 'root' })
export class UserDataProvider {

    public constructor() {

    }

    setData(data: any) {
        localStorage.setItem("user-data", JSON.stringify(data));
    }

    getUserData(): UserModel {
        return <UserModel>JSON.parse(<string>localStorage.getItem("user-data"));
    }
}