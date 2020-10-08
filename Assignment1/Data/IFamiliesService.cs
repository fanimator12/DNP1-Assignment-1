using System.Collections.Generic;
using Assignment1.Models;

namespace Assignment1.Data {
public interface IFamiliesService {
    IList<Family> GetFamilies();
    void        AddFamily(Family family);
    void        RemoveFamily(int familyId);
    void        Update(Family family);
}
}