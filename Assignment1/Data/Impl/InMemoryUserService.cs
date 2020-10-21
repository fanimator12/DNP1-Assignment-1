using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Assignment1.Models;
using Assignment1.Persistence;

namespace Assignment1.Data.Impl
{
    public class InMemoryUserService : IUserService
    {
        private FileContext service;
        private readonly string usersFile = "users.json";
        
        private IList<User> users;

        public InMemoryUserService()
        {
            if (!File.Exists(usersFile)) {
                WriteUsersToFile();
            } else {
                string content = File.ReadAllText(usersFile);
                users = JsonSerializer.Deserialize<List<User>>(content);
            }
        }

        public User ValidateUser(string userName, string password)
        {
            var first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null) throw new Exception("User not found");

            if (!first.Password.Equals(password)) throw new Exception("Incorrect password");

            return first;
        }
        
        private void WriteUsersToFile() {
            string productsAsJson = JsonSerializer.Serialize(users);

            File.WriteAllText(usersFile, productsAsJson);
        }
    }
}