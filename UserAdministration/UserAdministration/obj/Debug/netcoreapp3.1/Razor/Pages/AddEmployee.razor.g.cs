#pragma checksum "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\AddEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87ad4a09d299787f3a4f5fd60c2fd3a0c72c7c3a"
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
#line 1 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using UserAdministration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using UserAdministration.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddEmployee")]
    public partial class AddEmployee : UserAdministration.Data.Employee
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Add Employee</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\AddEmployee.razor"
                  Employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\AddEmployee.razor"
                                            HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n    ");
                __builder2.AddMarkupContent(10, "<label for=\"FirstName\">First Name</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "id", "firstName");
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\AddEmployee.razor"
                                           Employee.Firstname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Firstname = __value, Employee.Firstname))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.Firstname));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(17, "<label for=\"FirstName\">Last Name</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "id", "firstName");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\AddEmployee.razor"
                                           Employee.Lastname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Lastname = __value, Employee.Lastname))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.Lastname));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(24, "<label for=\"FirstName\">SSN</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(25);
                __builder2.AddAttribute(26, "id", "firstName");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\AddEmployee.razor"
                                           Employee.SocialSecurityNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.SocialSecurityNumber = __value, Employee.SocialSecurityNumber))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.SocialSecurityNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(31, "<label for=\"BirthDate\">Birthdate</label>\r\n    ");
                __Blazor.UserAdministration.Pages.AddEmployee.TypeInference.CreateInputDate_0(__builder2, 32, 33, "BirthDate", 34, 
#nullable restore
#line 21 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\AddEmployee.razor"
                                           Employee.Birthdate

#line default
#line hidden
#nullable disable
                , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Birthdate = __value, Employee.Birthdate)), 36, () => Employee.Birthdate);
                __builder2.AddMarkupContent(37, "\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(38, "<label for=\"IsActive\">Is Active?</label>\r\n    ");
                __builder2.OpenElement(39, "input");
                __builder2.AddAttribute(40, "type", "checkbox");
                __builder2.AddAttribute(41, "id", "IsActive");
                __builder2.AddAttribute(42, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\AddEmployee.razor"
                                                Employee.IsActive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Employee.IsActive = __value, Employee.IsActive));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n    <br>\r\n\r\n    ");
                __builder2.AddMarkupContent(45, "<button type=\"submit\">Add Employee</button>\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n");
            __builder.AddContent(47, 
#nullable restore
#line 30 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\AddEmployee.razor"
  Message

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\AddEmployee.razor"
       

    public UserAdministration.Data.Employee Employee = new Data.Employee();
    public string employeeID;
    private string Message="";


    public void HandleValidSubmit()
    {
        Employee.ID = Employee.SocialSecurityNumber + Employee.Firstname;
        if (CheckIfIDExists(Employee.ID))
        {
            Employee.ID = Employee.SocialSecurityNumber + Employee.Firstname;
            Console.WriteLine("HandleValidSubmit called");
            UserAdministration.Data.Employee.WriteEmployeeToCSV(Employee);
            employeeID = Employee.ID;
            Employee = new Data.Employee();
            Message = "Employee added";
        }
        else
            Message = "SSN+Firstname already exists";
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.UserAdministration.Pages.AddEmployee
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
