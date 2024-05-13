using System;

namespace EFDBsf2.Models
{
	public class User
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string Role { get; set; }

        // Навигационное свойство
        public UserCredential UserCredential { get; set; }

        // Внешний ключ
        public int CompanyId { get; set; }
        // Навигационное свойство
        public Company Company { get; set; }
    }
}
