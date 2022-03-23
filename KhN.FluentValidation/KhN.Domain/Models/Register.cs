
namespace KhN.Domain.Models
{
    public class Register
    {
        public Register()
        {

        }

        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public decimal Credit { get; set; }
    }
}
