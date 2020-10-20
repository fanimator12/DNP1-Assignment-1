using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Assignment1.Models;

namespace Assignment1.Data {
    //this component originally is the FileContext
public class FamilyService : IFamiliesService {
    private readonly string adultsFile = "adults.json";
    private readonly string familyFile = "families.json";
    private readonly string usersFile = "users.json";
    public IList<Family> families { get; private set; }
    public IList<Person> adults { get; private set; }
    public IList<User> users { get; private set; }

    public FamilyService() {
        families = File.Exists(familyFile) ? ReadData<Family>(familyFile) : new List<Family>();
        adults = File.Exists(adultsFile) ? ReadData<Person>(adultsFile) : new List<Person>();
        users = File.Exists(usersFile) ? ReadData<User>(usersFile) : new List<User>();
    }

    private IList<T> ReadData<T>(string s) {
        using (var jsonReader = File.OpenText(s)) {
            return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
        }
    }

    public IList<Family> GetFamilies() {
        List<Family> tmp = new List<Family>(families);
        return tmp;
    }

    public IList<Person> GetAdults() {
        List<Person> amp = new List<Person>(adults);
        return amp;
    }

    public IList<User> GetUsers() {
        List<User> smp = new List<User>(users);
        return smp;
    }

    public void AddFamily(Family family) {
        int max = families.Max(family => family.Id);
        family.Id = (++max);
        families.Add(family);
        SaveChanges();
    }

    public void RemoveFamily(int familyId) {
        Family toRemove = families.First(t => t.Id == familyId);
        families.Remove(toRemove);
        SaveChanges();
    }

    public void Update(Family family) {
        Family toUpdate = families.First(t => t.Id == family.Id);
        SaveChanges();
    }
    
    public void AddAdult(Person adult) {
        int max = adults.Max(adult => adult.Id);
        adult.Id = (++max);
        adults.Add(adult);
        SaveChanges();
    }
    public void SaveChanges() {
        // storing families
        string jsonFamilies = JsonSerializer.Serialize(families, new JsonSerializerOptions {
            WriteIndented = true
        });

        using (StreamWriter outputFile = new StreamWriter(familyFile, false)) {
            outputFile.Write(jsonFamilies);
        }

        // storing persons
        string jsonAdults = JsonSerializer.Serialize(adults, new JsonSerializerOptions {
            WriteIndented = true
        });

        using (StreamWriter outputFile = new StreamWriter(adultsFile, false)) {
            outputFile.Write(jsonAdults);
        }
    }
}
}