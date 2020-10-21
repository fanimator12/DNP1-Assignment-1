#pragma checksum "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\FamilyList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be8382c126e382ad7e55ccd1b158041bc33c06a1"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\dnp1\DNP1-Assignment-1\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dnp1\DNP1-Assignment-1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dnp1\DNP1-Assignment-1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dnp1\DNP1-Assignment-1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dnp1\DNP1-Assignment-1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dnp1\DNP1-Assignment-1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dnp1\DNP1-Assignment-1\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\dnp1\DNP1-Assignment-1\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\dnp1\DNP1-Assignment-1\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\FamilyList.razor"
using Assignment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\FamilyList.razor"
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
            __builder.AddMarkupContent(0, "<h1 xmlns=\"http://www.w3.org/1999/html\">Family list</h1>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Filter by User Id: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 8 "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\FamilyList.razor"
                                                        (arg) => FilterByUserId(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width:50px");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
#nullable restore
#line 11 "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\FamilyList.razor"
 if (familiesToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.AddMarkupContent(10, "<p>\r\n        <em>Loading...</em>\r\n    </p>\r\n");
#nullable restore
#line 16 "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\FamilyList.razor"
}
else if (!familiesToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.AddMarkupContent(12, "<p>\r\n        <em>No Family items exist. Please add some.</em>\r\n    </p>\r\n");
#nullable restore
#line 22 "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\FamilyList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "    ");
            __builder.OpenElement(14, "table");
            __builder.AddAttribute(15, "class", "table");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.AddMarkupContent(17, "<thead>\r\n        <tr>\r\n            <th>User ID</th>\r\n            <th>Address</th>\r\n            <th>Adults</th>\r\n            <th>Remove</th>\r\n        </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(18, "tbody");
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 35 "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\FamilyList.razor"
         foreach (var item in familiesToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "            ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 38 "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\FamilyList.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "td");
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.AddContent(28, 
#nullable restore
#line 40 "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\FamilyList.razor"
                     item.StreetName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, " <br> ");
            __builder.AddContent(30, 
#nullable restore
#line 40 "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\FamilyList.razor"
                                           item.HouseNumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 42 "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\FamilyList.razor"
                     item.Adults.ToList()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "td");
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\FamilyList.razor"
                                        () => RemoveFamily(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(40, "\r\n                        <i class=\"oi oi-trash\" style=\"color:red\"></i>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 49 "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\FamilyList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 52 "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\FamilyList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "D:\dnp1\DNP1-Assignment-1\Assignment1\Pages\FamilyList.razor"
       
    private IList<Family> familiesToShow;
    private IList<Family> allFamilies;

    private int? filterById;

    private void FilterByUserId(ChangeEventArgs changeEventArgs)
    {
        string errorMessage = "";
        filterById = null;
        try
        {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
        ExecuteFilter();
    }

    private void ExecuteFilter()
    {
        familiesToShow = allFamilies.Where(t =>
            filterById != null && t.Id == filterById || filterById == null
            ).ToList();
    }

    protected override async Task OnInitializedAsync()
    {
        allFamilies = FamilyService.GetFamilies();
        familiesToShow = allFamilies;
    }

    private void RemoveFamily(int adultId)
    {
        var familyToRemove = familiesToShow.First(t => t.Id == adultId);
        FamilyService.RemoveAdult(adultId);
        familiesToShow.Remove(familyToRemove);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamiliesService FamilyService { get; set; }
    }
}
#pragma warning restore 1591
