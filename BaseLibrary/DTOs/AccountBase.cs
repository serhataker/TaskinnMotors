
using System.ComponentModel.DataAnnotations;

namespace BaseLibrary.DTOs
{
    public class AccountBase
    {

        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
