using Domain.Entities;

namespace API.Data
{
    public static class UserDataExtension
    {
        public static void AddUsers(this IServiceCollection services)
        {
            var users = new List<User>
            {
                new User
                {
                    IsActive = true,
                    Name = "Vitor Archanjo Vasconcelos Chaves",
                    EnrollNumber = 2018019877,
                    CardId = "e9 u8 h2 a3",
                    Email = "archanjovitor@gmail.com",
                    Id = 1,
                    IsFump = false,
                    Password = "vitor123",
                    Phone = "37998315250"
                },
                new User
                {
                    IsActive = true,
                    Name = "Antony Gabriel",
                    EnrollNumber = 2019018765,
                    CardId = "e1 3e t5 h6",
                    Email = "antonygabriel@gmail.com",
                    Id = 2,
                    IsFump = false,
                    Password = "anthony123",
                    Phone = "31999211376"
                },
                new User
                {
                    IsActive = true,
                    Name = "Erica Pereira Silva",
                    EnrollNumber = 2018010165,
                    CardId = "0i k7 h2 x5",
                    Email = "ericapereira@gmail.com",
                    Id = 3,
                    IsFump = false,
                    Password = "erica123",
                    Phone = "31998765124"
                },
                new User
                {
                    IsActive = true,
                    Name = "Mario de Oliveria Silva",
                    EnrollNumber = 2016542918,
                    CardId = "p9 l7 h8 g6",
                    Email = "mario",
                    Id = 4,
                    IsFump = true,
                    Fump = Domain.Enums.Fump.LevelOne,
                    Password = "123",
                    Phone = "31999871254"
                },
                new User
                {
                    IsActive = true,
                    Name = "Joao Pereira Magalhaes",
                    EnrollNumber = 2020098765,
                    CardId = "j8 j9 h3 g2",
                    Email = "joaopereira@gmail.com",
                    Id = 5,
                    IsFump = true,
                    Fump = Domain.Enums.Fump.LevelTwo,
                    Password = "joao123",
                    Phone = "3199876342"
                },
                new User
                {
                    IsActive = true,
                    Name = "Estefania Mitre de Oliveria",
                    EnrollNumber = 2021098721,
                    CardId = "o2 i8 y6 r7",
                    Email = "estefaniamitre@gmail.com",
                    Id = 6,
                    IsFump = true,
                    Fump = Domain.Enums.Fump.LevelThree,
                    Password = "joao123",
                    Phone = "3199876342"
                },
                new User
                {
                    IsActive = true,
                    Name = "Ana Luiza Coutinho",
                    EnrollNumber = 2022091873,
                    CardId = "v3 c8 n1 a2",
                    Email = "analuiza@gmail.com",
                    Id = 7,
                    IsFump = true,
                    Fump = Domain.Enums.Fump.LevelFourA,
                    Password = "joao123",
                    Phone = "3199876342"
                },
                new User
                {
                    IsActive = true,
                    Name = "Julio de Lima Couto",
                    EnrollNumber = 2019098712,
                    CardId = "k8 l6 v2 x3",
                    Email = "juliolima@gmail.com",
                    Id = 8,
                    IsFump = true,
                    Fump = Domain.Enums.Fump.LevelFourB,
                    Password = "julio123",
                    Phone = "31999765431"
                }
            };

            services.AddSingleton(users);
        }
    }
}
