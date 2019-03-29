using System.ComponentModel.DataAnnotations;

namespace NTT.Backend.Api.DTO
{
    public class UserType
    {
        [Key]
        public int UserTypeId { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
    }
}