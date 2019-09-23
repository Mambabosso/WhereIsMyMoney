using System;

namespace WhereIsMyMoney.Data
{
    [Serializable]
    public sealed class Person
    {
        public string Id { get; private set; }

        public DateTime CreationDateTime { get; private set; }

        public string DisplayName { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Email { get; private set; }

        public string Phone { get; private set; }

        private Person()
        {
            Id = Guid.NewGuid().ToString("D");
            CreationDateTime = DateTime.Now;
        }

        public Person(string displayName, string firstName, string lastName, string email, string phone) : base()
        {
            if (string.IsNullOrWhiteSpace(displayName))
            {
                throw new ArgumentNullException("displayName");
            }
            DisplayName = displayName;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }
    }
}