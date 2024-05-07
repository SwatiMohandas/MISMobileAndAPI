using System.ComponentModel.DataAnnotations;

namespace DTO.Login
{
    public class UserLogins
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string IMEI { get; set; }

        public UserLogins()
        {

        }
    }
}
