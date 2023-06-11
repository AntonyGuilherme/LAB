export type UserSingUpModel = {
    name: string,
    email: string,
    password: string,
    enrollNumber: string
};

export type UserModel = {
    id: number;
    name: string;
    email: string
    fump: string;
    enrollNumber: string;
    cardId: string;
    isActive: boolean;
    paymentToken: string;
}