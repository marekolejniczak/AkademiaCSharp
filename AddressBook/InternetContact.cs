using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class InternetContact : GeneralPersonalDetails
    {
        public string Email { get; set; }

        public InternetContact(string name, string surname, string email)
        {
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
        }
    }
}
