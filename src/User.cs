﻿namespace management_system
{
    public class User : Person
    {

        private static int _instanceId;
         
        public User(string name, string email)
        {
            Name = name;
            Email = email;
            Id = _instanceId;
            _instanceId++;
        }
        public override string ToString()
        {
            return string.Format("User:\n\tName: {0}\n\tEmail: {1}\n\tId: {2}", Name, Email, Id);
        }

    }
}