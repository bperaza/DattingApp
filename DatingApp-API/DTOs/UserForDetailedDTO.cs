using System;
using System.Collections.Generic;
using DatingApp_API.Models;

namespace DatingApp_API.DTOs
{
    public class UserForDetailedDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        // Funciona como Llave del PasswordHash
        public byte[] PasswordSalt { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<PhotosForDetailedDTO> Photos { get; set; }
    }
}