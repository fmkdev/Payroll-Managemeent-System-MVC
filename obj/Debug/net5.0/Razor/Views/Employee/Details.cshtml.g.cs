#pragma checksum "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12efa86a20ea62753224b4563530655ba9be73e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Details), @"mvc.1.0.view", @"/Views/Employee/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\_ViewImports.cshtml"
using PayxApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\_ViewImports.cshtml"
using PayxApi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12efa86a20ea62753224b4563530655ba9be73e7", @"/Views/Employee/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81b62c4faf6c87acb2157b7b144752dde1bc2e99", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PayxApi.DTOs.EmployeeDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\Details.cshtml"
  
    Layout = "_PayxLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""card"">
    <div class=""card-body"">
        <h5 class=""card-title""></h5>

        <!-- List group with active and disabled items -->
        <ul class=""list-group"">
            <li class=""list-group-item active"" aria-current=""true"">PERSONAL DETAILS</li>
            <li class=""list-group-item""><b>FIRST NAME: </b> ");
#nullable restore
#line 14 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\Details.cshtml"
                                                       Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\"><b>LAST NAME: </b> ");
#nullable restore
#line 15 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\Details.cshtml"
                                                      Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\"><b>GENDER: </b> ");
#nullable restore
#line 16 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\Details.cshtml"
                                                   Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\"><b>MARITAL STATUS: </b> ");
#nullable restore
#line 17 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\Details.cshtml"
                                                           Write(Model.MaritalStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\"><b>EMAIL: </b> ");
#nullable restore
#line 18 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\Details.cshtml"
                                                  Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</li>\r\n            <li class=\"list-group-item\"><b>PHONE NUMBER: </b> ");
#nullable restore
#line 19 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\Details.cshtml"
                                                         Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\"><b>POSITION: </b> ");
#nullable restore
#line 20 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\Details.cshtml"
                                                     Write(Model.PositionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\"><b>DEPARTMENT: </b> ");
#nullable restore
#line 21 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\Details.cshtml"
                                                       Write(Model.DepartmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\"><b>APPOINTMENT: </b> ");
#nullable restore
#line 22 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\Details.cshtml"
                                                        Write(Model.AppointmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\"><b>PAY LEVEL: </b> ");
#nullable restore
#line 23 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\Details.cshtml"
                                                      Write(Model.PayLevelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\"><b>PAYMENT TYPE: </b> ");
#nullable restore
#line 24 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\Details.cshtml"
                                                         Write(Model.PaymentType);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
            <li class=""list-group-item"" aria-disabled=""true"">
            </li>
        </ul><!-- End ist group with active and disabled items -->

    </div>
</div>


<div class=""card"">
    <div class=""card-body"">
        <h5 class=""card-title""></h5>

        <!-- List group with active and disabled items -->
        <ul class=""list-group"">
            <li class=""list-group-item active"" aria-current=""true"">ADDRESS</li>
            <li class=""list-group-item""><b>HOUSE NUMBER: </b> ");
#nullable restore
#line 40 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\Details.cshtml"
                                                         Write(Model.HouseNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\"><b>STREET NAME: </b> ");
#nullable restore
#line 41 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\Details.cshtml"
                                                        Write(Model.StreetName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\"><b>L/G: </b> ");
#nullable restore
#line 42 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\Details.cshtml"
                                                Write(Model.LocalGovernment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\"><b>CITY: </b> ");
#nullable restore
#line 43 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\Details.cshtml"
                                                 Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\"><b>STATE: </b> ");
#nullable restore
#line 44 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\Details.cshtml"
                                                  Write(Model.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\"><b>NATIONALITY: </b> ");
#nullable restore
#line 45 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\Details.cshtml"
                                                        Write(Model.Nationality);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\"><b>HOME NUMBER: </b> ");
#nullable restore
#line 46 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\Details.cshtml"
                                                        Write(Model.HomeNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>

        </ul><!-- End ist group with active and disabled items -->

    </div>
</div>

</div>
<div class=""card"">
    <div class=""card-body"">
        <h5 class=""card-title""></h5>

        <!-- List group with active and disabled items -->
        <ul class=""list-group"">
            <li class=""list-group-item active"" aria-current=""true"">ADDRESS</li>
            <li class=""list-group-item""><b>ACCOUNT NUMBER: </b> ");
#nullable restore
#line 61 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\Details.cshtml"
                                                           Write(Model.AccountNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\"><b>BANK NAME: </b> ");
#nullable restore
#line 62 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\Details.cshtml"
                                                      Write(Model.BankName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n        </ul><!-- End ist group with active and disabled items -->\r\n\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PayxApi.DTOs.EmployeeDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
