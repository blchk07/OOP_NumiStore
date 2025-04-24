using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NumiStore.Models
{
    public abstract class User
    {
        string Login { get; set; }
        string Password { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string Email { get; set; }
        string Address { get; set; }
    }
}
