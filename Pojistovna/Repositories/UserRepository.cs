using Pojistovna.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojistovna.Repositories
{
    public class UserRepository
    {
        private readonly List<User> items;

        public UserRepository()
        {
            this.items = new List<User>();
        }

        public void Add(User user)
        {
            items.Add(user);
        }

        public List<User> GetAll()
        {
            return items;
        }

        public User Search(string firstName, string lastName)
        {
            foreach (var item in items)
            {
                if (item.FirstName.ToLower() == firstName.ToLower() && item.LastName.ToLower() == lastName.ToLower())
                {
                    return item;
                }
            }

            return null;
        }

        public List<User> Search(string text)
        {
            var list = new List<User>();

            foreach (var item in items)
            {
                if (item.FirstName.ToLower().Contains(text.ToLower()) || item.LastName.ToLower().Contains(text.ToLower()))
                {
                    list.Add(item); 
                }
            }

            return list;
        }
    }
}
