using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Assignment1.Models;

namespace Assignment1.Data {
public class FamilyService : IFamiliesService {

    private string familyFile = "families.json";
    private IList<Family> families;

    public FamilyService() {
        if (!File.Exists(familyFile)) {
            Seed();
            WriteFamiliesToFile();
        } else {
            string content = File.ReadAllText(familyFile);
            families = JsonSerializer.Deserialize<List<Family>>(content);
        }
    }

    public IList<Family> GetFamilies() {
        List<Family> tmp = new List<Family>(families);
        return tmp;
    }

    public void AddFamily(Family family) {
        int max = families.Max(family => family.FamilyId);
        family.FamilyId = (++max);
        families.Add(family);
        WriteFamiliesToFile();
    }

    public void RemoveFamily(int familyId) {
        Family toRemove = families.First(t => t.FamilyId == familyId);
        families.Remove(toRemove);
        WriteFamiliesToFile();
    }

    public void Update(Family family) {
        Family toUpdate = families.First(t => t.FamilyId == family.FamilyId);
        //toUpdate.IsCompleted = family.IsCompleted;
        WriteFamiliesToFile();
    }

    private void WriteFamiliesToFile() {
        string productsAsJson = JsonSerializer.Serialize(families);
        File.WriteAllText(familyFile, productsAsJson);
    }

    private void Seed() {
        Family[] ts = {
            new Family {
                UserId = 1,
                FamilyId = 1,
                Title = "Mooh",
                //IsCompleted = false
            }
        };
        families = ts.ToList();
    }
}
}