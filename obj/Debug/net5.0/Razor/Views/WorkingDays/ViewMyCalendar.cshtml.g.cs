#pragma checksum "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\WorkingDays\ViewMyCalendar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd252566802d238302f599d38999c41d5174586c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkingDays_ViewMyCalendar), @"mvc.1.0.view", @"/Views/WorkingDays/ViewMyCalendar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd252566802d238302f599d38999c41d5174586c", @"/Views/WorkingDays/ViewMyCalendar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81b62c4faf6c87acb2157b7b144752dde1bc2e99", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkingDays_ViewMyCalendar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PayxApi.DTOs.WorkingDaysDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\WorkingDays\ViewMyCalendar.cshtml"
  
    Layout = "_PayxLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main id=""main"" class=""main"">

    <div class=""pagetitle"">
      <h1>Data Tables</h1>
      <nav>
        <ol class=""breadcrumb"">
          <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
          <li class=""breadcrumb-item"">Tables</li>
          <li class=""breadcrumb-item active"">Data</li>
        </ol>
      </nav>
    </div><!-- End Page Title -->

    <section class=""section"">
      <div class=""row"">
        <div class=""col-lg-12"">

          <div class=""card"">
            <div class=""card-body"">
              <h5 class=""card-title"">Datatables</h5>
              <p>Add lightweight datatables to your project with using the <a href=""https://github.com/fiduswriter/Simple-DataTables"" target=""_blank"">Simple DataTables</a> library. Just add <code>.datatable</code> class name to any table you wish to conver to a datatable</p>

              <!-- Table with stripped rows -->
              <table class=""table datatable"">
                <thead>
                  <tr>
   ");
            WriteLiteral(@"                 <th scope=""col"">DATE</th>
                    <th scope=""col"">CARD ID</th>
                    <th scope=""col"">REQUEST</th>
                    <th scope=""col"">REQUEST STATUS</th>
                    <th scope=""col"">DAY STATUS</th>
                  </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 40 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\WorkingDays\ViewMyCalendar.cshtml"
             foreach (var calendar in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 43 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\WorkingDays\ViewMyCalendar.cshtml"
                               Write(Html.DisplayFor(e => calendar.WorkDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\WorkingDays\ViewMyCalendar.cshtml"
                   Write(Html.DisplayFor(e => calendar.EmployeeCardId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\WorkingDays\ViewMyCalendar.cshtml"
                   Write(Html.DisplayFor(e => calendar.Request));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\WorkingDays\ViewMyCalendar.cshtml"
                   Write(Html.DisplayFor(e => calendar.RequestStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                    \r\n                    <td>");
#nullable restore
#line 47 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\WorkingDays\ViewMyCalendar.cshtml"
                   Write(Html.DisplayFor(e => calendar.DayStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 49 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\WorkingDays\ViewMyCalendar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n              </table>\r\n              <!-- End Table with stripped rows -->\r\n\r\n            </div>\r\n          </div>\r\n\r\n        </div>\r\n      </div>\r\n    </section>\r\n\r\n  </main><!-- End #main -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PayxApi.DTOs.WorkingDaysDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
