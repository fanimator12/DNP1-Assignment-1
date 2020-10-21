using System.Collections.Generic;
using Assignment1.Models;

namespace Assignment1.Data
{
    public interface IFamiliesService
    {
        IList<Family> GetFamilies();
        IList<Person> GetAdults();
        void AddFamily(Family family);
        void RemoveFamily(int familyId);
        void Update(Family family);
        Person ValidatePerson(string firstName, string lastName, string sex, int id);
    }
}