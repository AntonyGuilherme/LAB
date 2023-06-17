using Domain.Models.Ufmg;

namespace API.Data
{
    public static class UfmgDataExtension
    {
        public static void UniversityStudents(this IServiceCollection services)
        {
            var users = new List<Student>
            {
                new Student
                {
                    IsActive = true,
                    CardId = "e9 u8 h2 a3",
                    IsFump = false,
                },
                new Student
                {
                    IsActive = true,
                    CardId = "e1 3e t5 h6",
                    IsFump = false,
                },
                new Student
                {
                    IsActive = true,
                    CardId = "0i k7 h2 x5",
                    IsFump = false,
                },
                new Student
                {
                    IsActive = true,
                    CardId = "p9 l7 h8 g6",
                    IsFump = true,
                    Fump = Domain.Enums.Fump.LevelOne,
                },
                new Student
                {
                    IsActive = true,
                    CardId = "j8 j9 h3 g2",
                    IsFump = true,
                    Fump = Domain.Enums.Fump.LevelTwo,
                },
                new Student
                {
                    IsActive = true,
                    CardId = "o2 i8 y6 r7",
                    IsFump = true,
                    Fump = Domain.Enums.Fump.LevelThree,
                },
                new Student
                {
                    IsActive = true,
                    CardId = "v3 c8 n1 a2",
                    IsFump = true,
                    Fump = Domain.Enums.Fump.LevelFourA,
                },
                new Student
                {
                    IsActive = true,
                    CardId = "k8 l6 v2 x3",
                    IsFump = true,
                    Fump = Domain.Enums.Fump.LevelFourB,
                }
            };

            services.AddSingleton(users);
        }
    }
}
