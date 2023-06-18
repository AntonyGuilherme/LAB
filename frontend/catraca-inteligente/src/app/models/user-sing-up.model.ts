export type UserSingUpModel = {
    name?: string,
    email?: string,
    password?: string,
    enrollNumber?: string,
    phone?: string
};

export type UserModel = {
    name: string,
    email: string,
    ufmgToken: string,
    ufmgEnrollment: string
}