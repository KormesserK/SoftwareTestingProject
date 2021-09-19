#pragma checksum "C:\Dev\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\ShowEmployees.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "888377dfad3c097ee385266a9079127f73e52bef"
// <auto-generated/>
#pragma warning disable 1591
namespace UserAdministration.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Dev\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Dev\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Dev\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Dev\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Dev\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Dev\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Dev\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using UserAdministration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Dev\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using UserAdministration.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ShowEmployees")]
    public partial class ShowEmployees : UserAdministration.Data.Employee
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ShowEmployees</h3>\r\n");
            __builder.AddMarkupContent(1, "<p>This component shows all Employees in our Database.</p>\r\n\r\n");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.AddMarkupContent(5, "<thead>\r\n        <tr>\r\n            <th>Firstname</th>\r\n            <th>Lastname</th>\r\n            <th>Security Number</th>\r\n            <th>Birthdate</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(6, "tbody");
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 18 "C:\Dev\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\ShowEmployees.razor"
         foreach (var employee in employees)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "            ");
            __builder.OpenElement(9, "tr");
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 21 "C:\Dev\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\ShowEmployees.razor"
                     employee.Firstname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 22 "C:\Dev\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\ShowEmployees.razor"
                     employee.Lastname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 23 "C:\Dev\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\ShowEmployees.razor"
                     employee.SocialSecurityNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 24 "C:\Dev\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\ShowEmployees.razor"
                     employee.Birthdate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 26 "C:\Dev\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\ShowEmployees.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Dev\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\ShowEmployees.razor"
       
    private List<UserAdministration.Data.Employee> employees = new List<UserAdministration.Data.Employee>();

    protected override async Task OnInitializedAsync()
    {
        employees = await Task.FromResult(UserAdministration.Data.Employee.ReadAllEmployees());
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591