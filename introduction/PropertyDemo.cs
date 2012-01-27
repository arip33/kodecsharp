using System;

namespace Kodecsharp.Example.Intro
{
    class PropertyDemo
    {
        [STAThread]
        public static void Main(string[] args)
        {
            User user = new User();
            user.Id = 1;
            user.Username = "admin";
            user.FirstName = "System";
            user.LastName = "Administrator";

            System.Console.WriteLine("User: " + user.Id + "; " +
                user.Username + "; " + user.FirstName + "; " +
                user.LastName);
        }
    }

    class User
    {
        private long id;
        private string username;
        private string firstName;
        private string lastName;

        public User()
        {
        }

        /// <summary>
        /// User ID Property
        /// </summary>
        public long Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        /// <summary>
        /// Username Property
        /// </summary>
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        /// <summary>
        /// Firstname Property
        /// </summary>
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        /// <summary>
        /// Lastname Property
        /// </summary>
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }        
    }
}
