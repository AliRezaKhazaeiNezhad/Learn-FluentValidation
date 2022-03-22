
using KhN.Domain.IModels;

namespace KhN.Domain.Models
{
    public class Organization : IContact
    {
        public Organization()
        {

        }

        public string Name { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
    }
}
