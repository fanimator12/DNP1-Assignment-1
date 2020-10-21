#pragma checksum "I:\VIA\dnp1\Assignment1\Assignment1\Pages\FamilyList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "669598864fe9f2cc38215f640d8e7152cd5fe2a2"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "I:\VIA\dnp1\Assignment1\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "I:\VIA\dnp1\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "I:\VIA\dnp1\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "I:\VIA\dnp1\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "I:\VIA\dnp1\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "I:\VIA\dnp1\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "I:\VIA\dnp1\Assignment1\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "I:\VIA\dnp1\Assignment1\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "I:\VIA\dnp1\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "I:\VIA\dnp1\Assignment1\Assignment1\Pages\FamilyList.razor"
using Assignment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "I:\VIA\dnp1\Assignment1\Assignment1\Pages\FamilyList.razor"
using Assignment1.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Families")]
    public partial class FamilyList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "I:\VIA\dnp1\Assignment1\Assignment1\Pages\FamilyList.razor"
       
    private IList<Family> familiesToShow;
    private IList<Family> allFamilies;

    private int? filterById;

    private void FilterByUserId(ChangeEventArgs changeEventArgs) {
        filterById = null;
        try {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        } catch (Exception e) { }
        ExecuteFilter();
    }

    private void ExecuteFilter() {
        familiesToShow = allFamilies.Where(t => 
            (filterById != null && t.Id == filterById || filterById == null)
        ).ToList();
    }

    protected override async Task OnInitializedAsync() {
        allFamilies = FamilyService.GetFamilies();
        familiesToShow = allFamilies;
    }

    private void RemoveFamily(int familyId) {
        Family familyToRemove = familiesToShow.First(t => t.Id == familyId);
        FamilyService.RemoveFamily(familyId);
        familiesToShow.Remove(familyToRemove);
    }

    private void CompletedChange(ChangeEventArgs evt, Family family) {
        FamilyService.Update(family);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamiliesService FamilyService { get; set; }
    }
}
#pragma warning restore 1591
