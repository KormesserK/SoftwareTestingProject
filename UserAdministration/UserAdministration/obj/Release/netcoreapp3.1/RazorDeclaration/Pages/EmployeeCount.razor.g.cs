#pragma checksum "C:\Dev\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\EmployeeCount.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16a421873d08fd067873f0c42a1c6ad8c07343ab"
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
#nullable restore
#line 10 "C:\Dev\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EmployeeCount")]
    public partial class EmployeeCount : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Dev\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\EmployeeCount.razor"
           
        private List<Data.Employee> EmployeeList;
        private string CalculatedGrowthString;
        private string NumberOfEmployeesString;


        protected override void OnInitialized()
        {
            EmployeeList = Data.Employee.ReadAllEmployees();
            CalculatedGrowthString = CalculateGrowth();
            NumberOfEmployeesString = NumberOfEmployees();
        }

        private string CalculateGrowth()
        {
            double startAmount = 4;
            double actualAmount = EmployeeList.Count();
            double growth = startAmount / actualAmount * 100;
            return "This is a growth of " + Math.Round(growth, 2).ToString() + " percent";
        }

        private string NumberOfEmployees()
        {
            return "The number of our Employees has grown from 4 to " + EmployeeList.Count();
        }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591