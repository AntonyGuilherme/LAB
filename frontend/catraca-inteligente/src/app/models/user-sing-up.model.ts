export type UserSingUpModel = {
    name?: string,
    email?: string,
    password?: string,
    enrollNumber?: string,
    phone?: string
};

export type UserModel = {
    id: number,
    cardId: string,
    name: string,
    enrollNumber: number,
    email: string,
    phone: number,
    isFump: boolean,
    fump: number,
    isActive: boolean,
    creditCard: string
}