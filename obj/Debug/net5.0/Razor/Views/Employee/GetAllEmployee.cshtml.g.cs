#pragma checksum "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa47a33104de3a27ada5a7e5fd8b51cb0587a5ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_GetAllEmployee), @"mvc.1.0.view", @"/Views/Employee/GetAllEmployee.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa47a33104de3a27ada5a7e5fd8b51cb0587a5ee", @"/Views/Employee/GetAllEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81b62c4faf6c87acb2157b7b144752dde1bc2e99", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_GetAllEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PayxApi.DTOs.EmployeeDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateEmployee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateAddress", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Address", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateAccountDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AccountDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
  
    Layout = "_PayxLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main id=""main"" class=""main"">

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
            WriteLiteral(@"               <th scope=""col"">#</th>
                    <th scope=""col"">Card-Id</th>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Department</th>
                    <th scope=""col"">Position</th>
                    <th scope=""col"">Details</th>
                    <th scope=""col"">Delete</th>
                  </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 41 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
             foreach (var employee in Model)
            {
                
            

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 46 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                               Write(Html.DisplayFor(e => employee.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th scope=\"row\">");
#nullable restore
#line 47 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                               Write(Html.DisplayFor(e => employee.EmployeeCardId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 48 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                   Write(Html.DisplayFor(e => employee.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                   Write(Html.DisplayFor(e => employee.DepartmentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                   Write(Html.DisplayFor(e => employee.PositionName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    <td>
                            <button type=""button"" class=""btn btn-primary"" data-bs-toggle=""modal"" data-bs-target=""#verticalycentered"">
                                Details
                            </button>
                            <div class=""modal fade"" id=""verticalycentered"" tabindex=""-1"">
                                <div class=""modal-dialog modal-dialog-centered"">
                                <div class=""modal-content"">
                                    <div class=""modal-header"">
                                    <h5 class=""modal-title""></h5>
                                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                                    </div>
                                    <div class=""modal-body"">

                                      <div class=""card"">
                                        <div class=""card-body"">
                                          <h5 clas");
            WriteLiteral(@"s=""card-title""></h5>

                                          <!-- List group with active and disabled items -->
                                          <ul class=""list-group"">
                                            <li class=""list-group-item active"" aria-current=""true"">PERSONAL DETAILS</li>
                                            <li class=""list-group-item""><b>FIRST NAME: </b> ");
#nullable restore
#line 71 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                                                                                       Write(Html.DisplayFor(e => employee.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>LAST NAME: </b> ");
#nullable restore
#line 72 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                                                                                      Write(Html.DisplayFor(e => employee.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>GENDER: </b> ");
#nullable restore
#line 73 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                                                                                   Write(Html.DisplayFor(e => employee.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>MARITAL STATUS: </b> ");
#nullable restore
#line 74 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                                                                                           Write(Html.DisplayFor(e => employee.MaritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>EMAIL: </b> ");
#nullable restore
#line 75 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                                                                                  Write(Html.DisplayFor(e => employee.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>PHONE NUMBER: </b> ");
#nullable restore
#line 76 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                                                                                         Write(Html.DisplayFor(e => employee.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>POSITION: </b> ");
#nullable restore
#line 77 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                                                                                     Write(Html.DisplayFor(e => employee.PositionName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>DEPARTMENT: </b> ");
#nullable restore
#line 78 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                                                                                       Write(Html.DisplayFor(e => employee.DepartmentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>APPOINTMENT: </b> ");
#nullable restore
#line 79 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                                                                                        Write(Html.DisplayFor(e => employee.AppointmentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>PAY LEVEL: </b> ");
#nullable restore
#line 80 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                                                                                      Write(Html.DisplayFor(e => employee.PayLevelName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>PAYMENT TYPE: </b> ");
#nullable restore
#line 81 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                                                                                         Write(Html.DisplayFor(e => employee.PaymentType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\" aria-disabled=\"true\">\r\n                                              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa47a33104de3a27ada5a7e5fd8b51cb0587a5ee15121", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-employeeId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                                                                                                                 WriteLiteral(employee.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["employeeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-employeeId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["employeeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
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
#line 98 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                                                                                         Write(Html.DisplayFor(e => employee.HouseNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>STREET NAME: </b> ");
#nullable restore
#line 99 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                                                                                        Write(Html.DisplayFor(e => employee.StreetName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>L/G: </b> ");
#nullable restore
#line 100 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                                                                                Write(Html.DisplayFor(e => employee.LocalGovernment));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>CITY: </b> ");
#nullable restore
#line 101 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                                                                                 Write(Html.DisplayFor(e => employee.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>STATE: </b> ");
#nullable restore
#line 102 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                                                                                  Write(Html.DisplayFor(e => employee.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>NATIONALITY: </b> ");
#nullable restore
#line 103 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                                                                                        Write(Html.DisplayFor(e => employee.Nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>HOME NUMBER: </b> ");
#nullable restore
#line 104 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                                                                                        Write(Html.DisplayFor(e => employee.HomeNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\" aria-disabled=\"true\">\r\n                                              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa47a33104de3a27ada5a7e5fd8b51cb0587a5ee21534", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-employeeId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 106 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                                                                                                               WriteLiteral(employee.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["employeeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-employeeId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["employeeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </li>
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
#line 121 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                                                                                           Write(Html.DisplayFor(e => employee.AccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>BANK NAME: </b> ");
#nullable restore
#line 122 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                                                                                      Write(Html.DisplayFor(e => employee.BankName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\" aria-disabled=\"true\">\r\n                                              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa47a33104de3a27ada5a7e5fd8b51cb0587a5ee25906", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-employeeId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 124 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
                                                                                                                             WriteLiteral(employee.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["employeeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-employeeId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["employeeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </li>
                                          </ul><!-- End ist group with active and disabled items -->

                                        </div>
                                      </div>
                                </div>
                                </div>
                            </div><!-- End Vertically centered Modal-->
                    </td>
                    <td><button type=""button"" class=""btn btn-danger"">Delete</button></td>
                  </tr>
");
#nullable restore
#line 136 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\Employee\GetAllEmployee.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PayxApi.DTOs.EmployeeDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
