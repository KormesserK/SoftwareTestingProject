// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace UserAdministration.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\user\source\repos\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\source\repos\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\source\repos\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\source\repos\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\source\repos\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\source\repos\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\source\repos\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using UserAdministration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\source\repos\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using UserAdministration.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\user\source\repos\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ShowEmployees")]
    public partial class ShowEmployees : UserAdministration.Data.Employee
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\user\source\repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\ShowEmployees.razor"
       
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
