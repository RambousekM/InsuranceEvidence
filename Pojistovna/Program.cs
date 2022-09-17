using Pojistovna.Model;
using Pojistovna.Controllers;
using Pojistovna.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diar
{

    class Program
    {
       
        static void Main(string[] args)
        {
            Welcome();

            var repo = new UserRepository();
            var controller = new UserController(repo);

            CreateInitialData(repo);

            char volba = '0';
            // hlavní cyklus
            while (volba != '5')
            {
                Console.WriteLine();
                Console.WriteLine("Select action:");
                Console.WriteLine("1 - Add");
                Console.WriteLine("2 - Search - exactly");
                Console.WriteLine("3 - Search - fulltext");
                Console.WriteLine("4 - List");
                Console.WriteLine("5 - Exit");
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();
                // reakce na volbu
                switch (volba)
                {
                    case '1':
                        controller.Add();
                        break;
                    case '2':
                        controller.SearchByName();
                        break;
                    case '3':
                        controller.SearchFulltext();
                        break;
                    case '4':
                        controller.ShowAll();
                        break;
                    case '5':
                        Console.WriteLine("Press any key for exit...");
                        break;
                    default:
                        Console.WriteLine("Invaid option press any key");
                        break;
                }
                Console.ReadKey();
            }
        }

        private static void CreateInitialData(UserRepository repo)
        {
            var user1 = new User("Michal", "Rambousek", 20, "+420777");
            repo.Add(user1);
            var user2 = new User("Jakub", "Lerch", 25, "+420666");
            repo.Add(user2);
        }

        static void Welcome()
        {
            Console.WriteLine("Hello, welcome!");
            Console.WriteLine("Application name: Register of insuranced clients");
            Console.WriteLine("Application ver. 1.0.0");
        }
    }
}