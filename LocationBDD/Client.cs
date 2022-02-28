using System;

namespace LocationBDD
{
    public class Client
    {
        public string Username { get; private set; }

        public string Password { get; private set; }

        public string Name { get; private set; }

        public string LastName { get; private set; }

        public DateTime Birthday { get; private set; }

        public DateTime LicenceDate { get; private set; }

        public Client(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public Client(string username, string password, string name, string lastName, DateTime licenceDate)
        {
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.LastName = lastName;
            this.Birthday = licenceDate;
        }
    }
}
