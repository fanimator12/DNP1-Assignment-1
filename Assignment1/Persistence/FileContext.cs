using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Assignment1.Data;
using Assignment1.Models;

namespace Assignment1.Persistence
{
    public class FileContext : IFamiliesService, IUserService
    {
        private readonly string adultsFile = "adults.json";

        private readonly string familiesFile = "families.json";
        
        private readonly string usersFile = "users.json";

        public FileContext()
        {
            Families = File.Exists(familiesFile) ? ReadData<Family>(familiesFile) : new List<Family>();
            Adults = File.Exists(adultsFile) ? ReadData<Adult>(adultsFile) : new List<Adult>();
            Children = File.Exists(familiesFile) ? ReadData<Child>(familiesFile) : new List<Child>();
            Pets = File.Exists(familiesFile) ? ReadData<Pet>(familiesFile) : new List<Pet>();
            Users = File.Exists(usersFile) ? ReadData<User>(usersFile) : new List<User>();
        }

        public IList<Family> Families { get; }
        public IList<Adult> Adults { get; }
        public IList<Child> Children { get; }
        public IList<Pet> Pets { get; }
        
        public IList<User> Users { get; }
        private IList<T> ReadData<T>(string s)
        {
            using (var jsonReader = File.OpenText(s))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }

        public void AddAdult(Adult adult)
        {
            var max = Adults.Max(adult => adult.Id);
            adult.Id = ++max;
            Adults.Add(adult);
            SaveChanges();
        }
        
      /*  public void AddChild(Child child)
        {
            var max = Children.Max(child => child.Id);
            child.Id = ++max;
            Children.Add(child);
            SaveChanges();
        }
        
        public void AddPet(Pet pet)
        {
            var max = Pets.Max(pet => pet.Id);
            pet.Id = ++max;
            Pets.Add(pet);
            SaveChanges();
        }*/
        public IList<Adult> GetAdults()
        {
            var amp = new List<Adult>(Adults);
            return amp;
        }
        
        public void RemoveAdult(int adultId)
        {
            var toRemove = Adults.First(t => t.Id == adultId);
            Adults.Remove(toRemove);
            SaveChanges();
        }
        public Person ValidatePerson(string firstName, string lastName, string sex, int id)
        {
            var validPerson = Adults.FirstOrDefault(adult => adult.FirstName.Equals(firstName));
            if (validPerson == null) throw new Exception("Person with this first name not found");

            if (!validPerson.LastName.Equals(lastName)) throw new Exception("Person with this last name not found");

            if (!validPerson.Sex.Equals(sex)) throw new Exception("Person with this sex not found");

            if (!validPerson.Id.Equals(id)) throw new Exception("Person with this ID not found");

            return validPerson;
        }

        public User ValidateUser(string userName, string password)
        {
            var first = Users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null) throw new Exception("User not found");

            if (!first.Password.Equals(password)) throw new Exception("Incorrect password");

            return first;
        }

        public void SaveChanges()
        {
            // storing families
            var jsonFamilies = JsonSerializer.Serialize(Families, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            using (var outputFile = new StreamWriter(familiesFile, false))
            {
                outputFile.Write(jsonFamilies);
            }

            // storing persons
            var jsonAdults = JsonSerializer.Serialize(Adults, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            using (var outputFile = new StreamWriter(adultsFile, false))
            {
                outputFile.Write(jsonAdults);
            }
        }
    }
}