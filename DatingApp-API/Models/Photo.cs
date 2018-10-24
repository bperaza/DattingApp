using System;

namespace DatingApp_API.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
        
        // Generar la Relacion Maestro/Detalle con la Tabla User
        // Cascade Delete Master-Detail
        //  onDelete: ReferentialAction.Cascade
        public User User { get; set; }
        public int UserId { get; set; }

    }
}