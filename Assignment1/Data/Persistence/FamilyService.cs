using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Assignment1.Models;

namespace Assignment1.Data
{
    public class FamilyService : IFamiliesService
    {
        private readonly string adultsFile = "adults.json";
        private readonly string familyFile = "families.json";
        private readonly string usersFile = "users.json";

        public FamilyService()
        {
            families = File.Exists(familyFile) ? ReadData<Family>(familyFile) : new List<Family>();
            adults = File.Exists(adultsFile) ? ReadData<Person>(adultsFile) : new List<Person>();
            users = File.Exists(usersFile) ? ReadData<User>(usersFile) : new List<User>();
        }

        public IList<Family> families { get; }
        public IList<Person> adults { get; }
        public IList<User> users { get; }

        public IList<Family> GetFamilies()
        {
            var tmp = new List<Family>(families);
            return tmp;
        }

        public IList<Person> GetAdults()
        {
            var amp = new List<Person>(adults);
            return amp;
        }

        public void AddFamily(Family family)
        {
            var max = families.Max(family => family.Id);
            family.Id = ++max;
            families.Add(family);
            SaveChanges();
        }

        public void RemoveFamily(int familyId)
        {
            var toRemove = families.First(t => t.Id == familyId);
            families.Remove(toRemove);
            SaveChanges();
        }

        public void Update(Family family)
        {
            var toUpdate = families.First(t => t.Id == family.Id);
            SaveChanges();
        }

        public Person ValidatePerson(string firstName, string lastName, string sex, int id)
        {
            var validPerson = adults.FirstOrDefault(adult => adult.FirstName.Equals(firstName));
            if (validPerson == null) throw new Exception("Adult with this first name not found");

            if (!validPerson.LastName.Equals(lastName)) throw new Exception("Adult with this last name not found");

            if (!validPerson.Sex.Equals(sex)) throw new Exception("Adult with this sex not found");

            if (!validPerson.Id.Equals(id)) throw new Exception("Adult with this ID not found");

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
            // storing families
            var jsonFamilies = JsonSerializer.Serialize(families, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            using (var outputFile = new StreamWriter(familyFile, false))
            {
                outputFile.Write(jsonFamilies);
            }

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