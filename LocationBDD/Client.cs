using System;
using System.Globalization;

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

        public Client(string username, string password, string name, string lastName, DateTime birthday)
        {
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.LastName = lastName;
            this.Birthday = birthday;
        }

        public int Age()
        {
            return (DateTime.Now.Year - this.Birthday.Year); 
        }

        public Boolean estMajeur()
        {
            return this.Age() > 17 ? true : false;
        }


        public int anciennetePermis()
        {
            return (DateTime.Now.Month - this.LicenceDate);
        }

        public Boolean permisValide(DateTime permis)
        {
            this.LicenceDate = permis;
            return this.anciennetePermis() > 6 ? true : false;
        }
    }
}
