using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Assignment1.Models;

namespace Assignment1.Data.Persistence
{
    public class FamilyService : IFamiliesService
    {
        private readonly string familiesFile = "families.json";
        private readonly string adultsFile = "adults.json";
        private readonly string usersFile = "users.json";

        public FamilyService()
        {
            families = File.Exists(familiesFile) ? ReadData<Family>(familiesFile) : new List<Family>();
            adults = File.Exists(adultsFile) ? ReadData<Adult>(adultsFile) : new List<Adult>();
            users = File.Exists(usersFile) ? ReadData<User>(usersFile) : new List<User>();
        }
        public IList<Family> families { get; }
        public IList<Adult> adults { get; }
        public IList<User> users { get; }

        public IList<Adult> GetAdults()
        {
            var amp = new List<Adult>(adults);
            return amp;
        }
        
        public IList<Family> GetFamilies()
        {
            var tmp = new List<Family>(families);
            return tmp;
        }

        public void AddAdult(Adult adult)
        {
            var max = adults.Max(adult => adult.Id);
            adult.Id = ++max;
            adults.Add(adult);
            SaveChanges();
        }

        public void RemoveAdult(int adultId)
        {
            var toRemove = adults.First(t => t.Id == adultId);
            adults.Remove(toRemove);
            SaveChanges();
        }

        public void Update(Adult adult)
        {
            var toUpdate = adults.First(t => t.Id == adult.Id);
            SaveChanges();
        }

        public Person ValidatePerson(string firstName, string lastName, string sex, int id)
        {
            var validPerson = adults.FirstOrDefault(adult => adult.FirstName.Equals(firstName));
            if (validPerson == null) throw new Exception("Person with this first name not found");

            if (!validPerson.LastName.Equals(lastName)) throw new Exception("Person with this last name not found");

            if (!validPerson.Sex.Equals(sex)) throw new Exception("Person with this sex not found");

            if (!validPerson.Id.Equals(id)) throw new Exception("Person with this ID not found");

            return validPerson;
        }

        private IList<T> ReadData<T>(string s)
        {
            using (var jsonReader = File.OpenText(s))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }

        public IList<User> GetUsers()
        {
            var smp = new List<User>(users);
            return smp;
        }

        public void SaveChanges()
        {
           /* // storing families
            var jsonFamilies = JsonSerializer.Serialize(families, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            using (var outputFile = new StreamWriter(familyFile, false))
            {
                outputFile.Write(jsonFamilies);
            }
*/
            // storing persons
            var jsonAdults = JsonSerializer.Serialize(adults, new JsonSerializerOptions
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