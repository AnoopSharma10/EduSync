﻿namespace EduSyncWebAPI.DTO
{
    public class UserModelDTO
    {
        public Guid UserId { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Role { get; set; }

        public string? PasswordHash { get; set; }
    }
}
