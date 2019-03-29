using System.ComponentModel.DataAnnotations;

namespace NTT.Backend.Api.DTO
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ImagePath { get; set; }
        public int UserTypeId { get; set; }
    }
}