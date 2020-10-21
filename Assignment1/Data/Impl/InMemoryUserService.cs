using System;
using System.Collections.Generic;
using System.Linq;
using Assignment1.Data.Persistence;
using Assignment1.Models;

namespace Assignment1.Data.Impl
{
    public class InMemoryUserService : IUserService
    {
        private FamilyService service;
        private readonly List<User> users;

        public InMemoryUserService()
        {
            users = service.GetUsers().ToList();
        }


        public User ValidateUser(string userName, string password)
        {
            var first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null) throw new Exception("User not found");

            if (!first.Password.Equals(password)) throw new Exception("Incorrect password");

            return first;
        }
    }
}