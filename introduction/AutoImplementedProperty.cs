using System;

namespace Kodecsharp.Example.Intro
{
    class AutoImplementedProperty
    {
        [STAThread]
        static void Main(string[] args)
        {
            UserAccount user = new UserAccount(1);
            user.Username = "admin";
            user.FirstName = "System";
            user.LastName = "Administrator";

            Console.WriteLine(user);
        }
    }

    class UserAccount
    {
        //
        // Auto-implemented properties
        //
        public long Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// Creates a new UserAccount with the specified Id.
        /// </summary>
        /// <param name="id">a UserAccount Id</param>
        public UserAccount(long id)
        {
            Id = id;
        }

        /// <summary>
        /// A string representation of this object.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Id: {0}; Username: {1}; " + 
                "FirstName: {2}; LastName: {3}", 
                Id, Username, FirstName, LastName);
        }
    }
}
