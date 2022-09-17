using Pojistovna.Model;
using Pojistovna.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojistovna.Controllers
{
    public class UserController
    {
        private readonly UserRepository userRepository;

        public UserController(UserRepository repository)
        {
            //userRepository = new UserRepository();
            userRepository = repository;
        }
        public void Add()
        {
            Console.WriteLine("Write Your name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Write Your ĺast name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Write Your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Write Your phone number");
            string phone = Console.ReadLine();
            User user = new User(firstName, lastName, age, phone);
            userRepository.Add(user);
        }

        public void ShowAll()
        {
            var list = userRepository.GetAll();
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void SearchByName()
        {
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Eneter ĺast name");
            string lastName = Console.ReadLine();
            
            var user = userRepository.Search(firstName, lastName);
            if (user != null)
            {
                Console.WriteLine(user.ToString());
            }
        }

        public void SearchFulltext()
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();

            if (!string.IsNullOrEmpty(text))
            {
                var users = userRepository.Search(text);
                if (users.Count > 0)
                {
                    foreach (var user in users)
                    {
                        Console.WriteLine(user.ToString());
                    }
                }
            }
        }
    }
}
