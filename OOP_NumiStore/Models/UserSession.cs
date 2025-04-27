using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NumiStore.Models
{
    public static class UserSession
    {
        public static User currentUser { get; private set; }
        public static void Login(User user)
        {
            currentUser = user;
        }

        public static void Logout()
        {
            currentUser = null;
        }
    }
}
