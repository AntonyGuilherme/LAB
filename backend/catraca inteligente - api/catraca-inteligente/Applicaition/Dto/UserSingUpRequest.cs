﻿namespace Applicaition.Dto
{
    public class UserSingUpRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int EnrollNumber { get; set; }
        public string Password { get; set; }
        public int Phone { get; set; }
        public bool IsFump { get; set; }
    }
}
