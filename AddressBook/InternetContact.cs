namespace AddressBook
{
    public class InternetContact : GeneralPersonalDetails
    {
        public string Email { get; set; }

        public InternetContact()
        {

        }

        public InternetContact(string name, string surname, string email)
        {
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
        }
    }
}
