﻿
namespace KhN.Domain.Models
{
    public class User
    {
        public User()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public List<string> Addresses { get; set; }
    }
}
