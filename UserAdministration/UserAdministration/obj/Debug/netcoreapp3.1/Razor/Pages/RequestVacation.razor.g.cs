#pragma checksum "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\RequestVacation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac4fbbfbdc10e23a49181e84aadce8e493185982"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/RequestVacation")]
    public partial class RequestVacation : UserAdministration.Data.Employee
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Request Vacation</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\RequestVacation.razor"
                  Vacation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\RequestVacation.razor"
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
                __builder2.AddMarkupContent(9, "\r\n\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(10, "<label for=\"firstDay\">First Day</label>\r\n    ");
                __Blazor.UserAdministration.Pages.RequestVacation.TypeInference.CreateInputDate_0(__builder2, 11, 12, "firstDay", 13, 
#nullable restore
#line 13 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\RequestVacation.razor"
                                          Vacation.firstDay

#line default
#line hidden
#nullable disable
                , 14, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Vacation.firstDay = __value, Vacation.firstDay)), 15, () => Vacation.firstDay);
                __builder2.AddMarkupContent(16, "\r\n    <br>");
                __builder2.AddMarkupContent(17, "<label for=\"lastDay\">Last Day</label>\r\n    ");
                __Blazor.UserAdministration.Pages.RequestVacation.TypeInference.CreateInputDate_1(__builder2, 18, 19, "lastDay", 20, 
#nullable restore
#line 15 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\RequestVacation.razor"
                                         Vacation.lastDay

#line default
#line hidden
#nullable disable
                , 21, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Vacation.lastDay = __value, Vacation.lastDay)), 22, () => Vacation.lastDay);
                __builder2.AddMarkupContent(23, "\r\n    <br>");
                __builder2.AddMarkupContent(24, "<label for=\"employee\">Employee-ID</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(25);
                __builder2.AddAttribute(26, "id", "employee");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\RequestVacation.razor"
                                          employeeID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => employeeID = __value, employeeID))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => employeeID));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n    <br>\r\n    <br>\r\n\r\n    ");
                __builder2.AddMarkupContent(31, "<button type=\"submit\">Request</button>\r\n    <br><br><br>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\r\n");
            __builder.AddContent(33, 
#nullable restore
#line 24 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\RequestVacation.razor"
  Availability

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\marti\Source\Repos\SoftwareTestingProject\UserAdministration\UserAdministration\Pages\RequestVacation.razor"
       

    public Data.Vacation Vacation = new Data.Vacation();
    public string employeeID;
    private string Availability;

    private void HandleValidSubmit()
    {
        Console.WriteLine("HandleValidSubmit called");
        if (Vacation.CheckDates())
            Availability = Vacation.CheckRequest(employeeID);
        else Availability = "Last day should be after first day!";
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.UserAdministration.Pages.RequestVacation
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
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
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
