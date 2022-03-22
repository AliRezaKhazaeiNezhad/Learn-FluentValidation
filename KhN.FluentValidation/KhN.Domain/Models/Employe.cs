
using KhN.Domain.IModels;

namespace KhN.Domain.Models
{
    public class Employe : IContact
    {
        public Employe()
        {

        }

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
