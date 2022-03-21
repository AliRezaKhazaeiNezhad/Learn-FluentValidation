
using KhN.Domain.Models;

namespace KhN.Cons 
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            if (string.IsNullOrEmpty(user.FirstName))
            {
                Console.WriteLine("Please enter the FirstName");
            }


            if (string.IsNullOrEmpty(user.LastName))
            {
                Console.WriteLine("Please enter the LastName");
            }


            Console.WriteLine("Please [Enter] To Exit ...");
        }
    }
}