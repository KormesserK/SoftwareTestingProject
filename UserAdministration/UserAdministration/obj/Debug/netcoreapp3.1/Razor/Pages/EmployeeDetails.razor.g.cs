#pragma checksum "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\EmployeeDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8c370a28f3b05b5a205b7d4e58a5bc07b61c777"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditEmployee")]
    public partial class EmployeeDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Details</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\EmployeeDetails.razor"
                   ShownEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\EmployeeDetails.razor"
                                                  HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.AddMarkupContent(6, "<label for=\"ID\">ID</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(7);
                __builder2.AddAttribute(8, "id", "ID");
                __builder2.AddAttribute(9, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\EmployeeDetails.razor"
                                    ShownEmployee.ID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ShownEmployee.ID = __value, ShownEmployee.ID))));
                __builder2.AddAttribute(11, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ShownEmployee.ID));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(13, "<label for=\"FirstName\">First Name</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "id", "firstName");
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\EmployeeDetails.razor"
                                           ShownEmployee.Firstname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ShownEmployee.Firstname = __value, ShownEmployee.Firstname))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ShownEmployee.Firstname));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(20, "<label for=\"FirstName\">Last Name</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "id", "firstName");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\EmployeeDetails.razor"
                                           ShownEmployee.Lastname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ShownEmployee.Lastname = __value, ShownEmployee.Lastname))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ShownEmployee.Lastname));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(27, "<label for=\"FirstName\">SSN</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "id", "firstName");
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\EmployeeDetails.razor"
                                           ShownEmployee.SocialSecurityNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ShownEmployee.SocialSecurityNumber = __value, ShownEmployee.SocialSecurityNumber))));
                __builder2.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ShownEmployee.SocialSecurityNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(34, "<label for=\"BirthDate\">Birthdate</label>\r\n    ");
                __Blazor.UserAdministration.Pages.EmployeeDetails.TypeInference.CreateInputDate_0(__builder2, 35, 36, "BirthDate", 37, 
#nullable restore
#line 19 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\EmployeeDetails.razor"
                                           ShownEmployee.Birthdate

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ShownEmployee.Birthdate = __value, ShownEmployee.Birthdate)), 39, () => ShownEmployee.Birthdate);
                __builder2.AddMarkupContent(40, "\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(41, "<label for=\"IsActive\">Is Active?</label>\r\n    ");
                __builder2.OpenElement(42, "input");
                __builder2.AddAttribute(43, "type", "checkbox");
                __builder2.AddAttribute(44, "id", "IsActive");
                __builder2.AddAttribute(45, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\EmployeeDetails.razor"
                                                ShownEmployee.IsActive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ShownEmployee.IsActive = __value, ShownEmployee.IsActive));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n    <br>\r\n\r\n    ");
                __builder2.AddMarkupContent(48, "<button type=\"submit\">Update Employee</button>\r\n\r\n\r\n    <br>\r\n    <br>\r\n    <br>\r\n    <br>\r\n    ");
                __builder2.OpenElement(49, "button");
                __builder2.AddAttribute(50, "type", "button");
                __builder2.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\EmployeeDetails.razor"
                                    () => ShowLastEmployee()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(52, "Last Employee");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n    ");
                __builder2.OpenElement(54, "button");
                __builder2.AddAttribute(55, "type", "button");
                __builder2.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\EmployeeDetails.razor"
                                    () => ShowNextEmployee()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(57, "Next Employee");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\EmployeeDetails.razor"
       

    public List<Data.Employee> EmployeeList = Data.Employee.ReadAllEmployees();
    public Data.Employee ShownEmployee = new Data.Employee();

    protected override void OnInitialized()
    {
        ShownEmployee = EmployeeList.Count > 0 ? EmployeeList[0] : ShownEmployee;
    }

    private void HandleValidSubmit()
    {
        UserAdministration.Data.Employee.UpdateEmployee(EmployeeList, ShownEmployee);
        Console.WriteLine("HandleValidSubmit called");
    }

    public void ShowNextEmployee()
    {
        try
        {
            ShownEmployee = EmployeeList[EmployeeList.IndexOf(ShownEmployee)+1];
        }
        catch (Exception)
        {
        }
    }

    public void ShowLastEmployee()
    {
        try
        {
            ShownEmployee = EmployeeList[EmployeeList.IndexOf(ShownEmployee)-1];
        }
        catch (Exception)
        {
        }
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.UserAdministration.Pages.EmployeeDetails
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
