#pragma checksum "C:\Dev\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\NextBirthday.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f653e9aa84398472e0479058270894628b76cc9"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/NextBirthday")]
    public partial class NextBirthday : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Dev\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\NextBirthday.razor"
       

    private List<Data.Employee> EmployeeList;
    private string NextBirthdayEmp;

    protected override void OnInitialized()
    {
        EmployeeList = Data.Employee.ReadAllEmployees();
        NextBirthdayEmp = NameOfNextBirthday();
    }

    private string NameOfNextBirthday()
    {
        var birthdayEmployee = CalculateNextBirthday();
        return birthdayEmployee.Firstname + " " + birthdayEmployee.Lastname + " with a Birthday on " + birthdayEmployee.Birthdate.Day + "." + birthdayEmployee.Birthdate.Month + "." + birthdayEmployee.Birthdate.Year;
    }

    private Data.Employee CalculateNextBirthday()
    {
        var minAmountBetweenNowAndBirthday = int.MaxValue;
        var today = DateTime.Now;
        EmployeeList = Data.Employee.ReadAllEmployees();
        Data.Employee nextBirthdayEmployee = new Data.Employee();

        foreach (Data.Employee emp in EmployeeList)
        {
            emp.Birthdate = new DateTime(today.Year, emp.Birthdate.Month, emp.Birthdate.Day);
            if (emp.Birthdate >= today)
            {
                var daysBetween = Convert.ToInt32(Math.Abs((emp.Birthdate - today).TotalDays));
                if (daysBetween < minAmountBetweenNowAndBirthday)
                {
                    nextBirthdayEmployee = emp;
                    minAmountBetweenNowAndBirthday = daysBetween;
                }
            }
        }
    
        return nextBirthdayEmployee;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
