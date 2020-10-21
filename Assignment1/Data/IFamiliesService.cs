using System.Collections.Generic;
using Assignment1.Models;

namespace Assignment1.Data
{
    public interface IFamiliesService
    {
        IList<Adult> GetAdults();
        void AddAdult(Adult adult);
        void RemoveAdult(int adultId);
        //void Update(Adult adult);
        Person ValidatePerson(string firstName, string lastName, string sex, int id);
    }
}