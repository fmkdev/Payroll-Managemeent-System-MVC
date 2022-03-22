#pragma checksum "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebf19fcf102b7adcd4c402ecd4e6ec33868b6e77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Profile), @"mvc.1.0.view", @"/Views/User/Profile.cshtml")]
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
#nullable restore
#line 1 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebf19fcf102b7adcd4c402ecd4e6ec33868b6e77", @"/Views/User/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81b62c4faf6c87acb2157b7b144752dde1bc2e99", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PayxApi.DTOs.EmployeeDTO>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
  
    Layout = "_PayxLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main id=""main"" class=""main"">

    <div class=""pagetitle"">
      <h1>Profile</h1>
      <nav>
        <ol class=""breadcrumb"">
          <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
          <li class=""breadcrumb-item"">Users</li>
          <li class=""breadcrumb-item active"">Profile</li>
        </ol>
      </nav>
    </div><!-- End Page Title -->

    <section class=""section profile"">
      <div class=""row"">
        <div class=""col-xl-4"">

          <div class=""card"">
            <div class=""card-body profile-card pt-4 d-flex flex-column align-items-center"">

              <img src=""assets/img/profile-img.jpg"" alt=""Profile"" class=""rounded-circle"">
              <h2>");
#nullable restore
#line 27 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
             Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n              <h3>");
#nullable restore
#line 28 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
             Write(User.FindFirst(ClaimTypes.GivenName).Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
              <div class=""social-links mt-2"">
                <a href=""#"" class=""twitter""><i class=""bi bi-twitter""></i></a>
                <a href=""#"" class=""facebook""><i class=""bi bi-facebook""></i></a>
                <a href=""#"" class=""instagram""><i class=""bi bi-instagram""></i></a>
                <a href=""#"" class=""linkedin""><i class=""bi bi-linkedin""></i></a>
              </div>
            </div>
          </div>

        </div>

        <div class=""col-xl-8"">

          <div class=""card"">
            <div class=""card-body pt-3"">
              <!-- Bordered Tabs -->
              <ul class=""nav nav-tabs nav-tabs-bordered"">

                <li class=""nav-item"">
                  <button class=""nav-link active"" data-bs-toggle=""tab"" data-bs-target=""#profile-overview"">Overview</button>
                </li>

                <li class=""nav-item"">
                  <button class=""nav-link"" data-bs-toggle=""tab"" data-bs-target=""#profile-edit"">Edit Profile</button>
               ");
            WriteLiteral(@" </li>

                <li class=""nav-item"">
                  <button class=""nav-link"" data-bs-toggle=""tab"" data-bs-target=""#profile-settings"">Settings</button>
                </li>

                <li class=""nav-item"">
                  <button class=""nav-link"" data-bs-toggle=""tab"" data-bs-target=""#profile-change-password"">Change Password</button>
                </li>

              </ul>
              <div class=""tab-content pt-2"">

                <div class=""tab-pane fade show active profile-overview"" id=""profile-overview"">
                  <h5 class=""card-title"">About</h5>
                  <p class=""small fst-italic"">Sunt est soluta temporibus accusantium neque nam maiores cumque temporibus. Tempora libero non est unde veniam est qui dolor. Ut sunt iure rerum quae quisquam autem eveniet perspiciatis odit. Fuga sequi sed ea saepe at unde.</p>

                  <h5 class=""card-title"">Profile Details</h5>

                  <div class=""card"">
                                     ");
            WriteLiteral(@"   <div class=""card-body"">
                                          <h5 class=""card-title""></h5>

                                          <!-- List group with active and disabled items -->
                                          <ul class=""list-group"">
                                            <li class=""list-group-item active"" aria-current=""true"">PERSONAL DETAILS</li>
                                            <li class=""list-group-item""><b>FIRST NAME: </b> ");
#nullable restore
#line 79 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
                                                                                       Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>LAST NAME: </b> ");
#nullable restore
#line 80 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
                                                                                      Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>GENDER: </b> ");
#nullable restore
#line 81 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
                                                                                   Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>MARITAL STATUS: </b> ");
#nullable restore
#line 82 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
                                                                                           Write(Model.MaritalStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>EMAIL: </b> ");
#nullable restore
#line 83 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
                                                                                  Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</li>\r\n                                            <li class=\"list-group-item\"><b>PHONE NUMBER: </b> ");
#nullable restore
#line 84 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
                                                                                         Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>POSITION: </b> ");
#nullable restore
#line 85 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
                                                                                     Write(Model.PositionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>DEPARTMENT: </b> ");
#nullable restore
#line 86 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
                                                                                       Write(Model.DepartmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>APPOINTMENT: </b> ");
#nullable restore
#line 87 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
                                                                                        Write(Model.AppointmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>PAY LEVEL: </b> ");
#nullable restore
#line 88 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
                                                                                      Write(Model.PayLevelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>PAYMENT TYPE: </b> ");
#nullable restore
#line 89 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
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
#line 105 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
                                                                                         Write(Model.HouseNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>STREET NAME: </b> ");
#nullable restore
#line 106 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
                                                                                        Write(Model.StreetName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>L/G: </b> ");
#nullable restore
#line 107 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
                                                                                Write(Model.LocalGovernment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>CITY: </b> ");
#nullable restore
#line 108 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
                                                                                 Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>STATE: </b> ");
#nullable restore
#line 109 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
                                                                                  Write(Model.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>NATIONALITY: </b> ");
#nullable restore
#line 110 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
                                                                                        Write(Model.Nationality);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>HOME NUMBER: </b> ");
#nullable restore
#line 111 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
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
#line 126 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
                                                                                           Write(Model.AccountNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\"><b>BANK NAME: </b> ");
#nullable restore
#line 127 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Profile.cshtml"
                                                                                      Write(Model.BankName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                            
                                          </ul><!-- End ist group with active and disabled items -->

                                        </div>
                                      </div>
                                </div>
                                </div>

                </div>

                <div class=""tab-pane fade profile-edit pt-3"" id=""profile-edit"">

                  <!-- Profile Edit Form -->
                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebf19fcf102b7adcd4c402ecd4e6ec33868b6e7717372", async() => {
                WriteLiteral(@"
                    <div class=""row mb-3"">
                      <label for=""profileImage"" class=""col-md-4 col-lg-3 col-form-label"">Profile Image</label>
                      <div class=""col-md-8 col-lg-9"">
                        <img src=""assets/img/profile-img.jpg"" alt=""Profile"">
                        <div class=""pt-2"">
                          <a href=""#"" class=""btn btn-primary btn-sm"" title=""Upload new profile image""><i class=""bi bi-upload""></i></a>
                          <a href=""#"" class=""btn btn-danger btn-sm"" title=""Remove my profile image""><i class=""bi bi-trash""></i></a>
                        </div>
                      </div>
                    </div>

                    <div class=""row mb-3"">
                      <label for=""fullName"" class=""col-md-4 col-lg-3 col-form-label"">Full Name</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""fullName"" type=""text"" class=""form-control"" id=""fullName"" value=""Kevin Anderson"">
      ");
                WriteLiteral(@"                </div>
                    </div>

                    <div class=""row mb-3"">
                      <label for=""about"" class=""col-md-4 col-lg-3 col-form-label"">About</label>
                      <div class=""col-md-8 col-lg-9"">
                        <textarea name=""about"" class=""form-control"" id=""about"" style=""height: 100px"">Sunt est soluta temporibus accusantium neque nam maiores cumque temporibus. Tempora libero non est unde veniam est qui dolor. Ut sunt iure rerum quae quisquam autem eveniet perspiciatis odit. Fuga sequi sed ea saepe at unde.</textarea>
                      </div>
                    </div>

                    <div class=""row mb-3"">
                      <label for=""company"" class=""col-md-4 col-lg-3 col-form-label"">Company</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""company"" type=""text"" class=""form-control"" id=""company"" value=""Lueilwitz, Wisoky and Leuschke"">
                      </div>
             ");
                WriteLiteral(@"       </div>

                    <div class=""row mb-3"">
                      <label for=""Job"" class=""col-md-4 col-lg-3 col-form-label"">Job</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""job"" type=""text"" class=""form-control"" id=""Job"" value=""Web Designer"">
                      </div>
                    </div>

                    <div class=""row mb-3"">
                      <label for=""Country"" class=""col-md-4 col-lg-3 col-form-label"">Country</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""country"" type=""text"" class=""form-control"" id=""Country"" value=""USA"">
                      </div>
                    </div>

                    <div class=""row mb-3"">
                      <label for=""Address"" class=""col-md-4 col-lg-3 col-form-label"">Address</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""address"" type=""text"" class=""form-control"" id=");
                WriteLiteral(@"""Address"" value=""A108 Adam Street, New York, NY 535022"">
                      </div>
                    </div>

                    <div class=""row mb-3"">
                      <label for=""Phone"" class=""col-md-4 col-lg-3 col-form-label"">Phone</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""phone"" type=""text"" class=""form-control"" id=""Phone"" value=""(436) 486-3538 x29071"">
                      </div>
                    </div>

                    <div class=""row mb-3"">
                      <label for=""Email"" class=""col-md-4 col-lg-3 col-form-label"">Email</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""email"" type=""email"" class=""form-control"" id=""Email"" value=""k.anderson@example.com"">
                      </div>
                    </div>

                    <div class=""row mb-3"">
                      <label for=""Twitter"" class=""col-md-4 col-lg-3 col-form-label"">Twitter Profile</label>
                WriteLiteral(@"
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""twitter"" type=""text"" class=""form-control"" id=""Twitter"" value=""https://twitter.com/#"">
                      </div>
                    </div>

                    <div class=""row mb-3"">
                      <label for=""Facebook"" class=""col-md-4 col-lg-3 col-form-label"">Facebook Profile</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""facebook"" type=""text"" class=""form-control"" id=""Facebook"" value=""https://facebook.com/#"">
                      </div>
                    </div>

                    <div class=""row mb-3"">
                      <label for=""Instagram"" class=""col-md-4 col-lg-3 col-form-label"">Instagram Profile</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""instagram"" type=""text"" class=""form-control"" id=""Instagram"" value=""https://instagram.com/#"">
                      </div>
               ");
                WriteLiteral(@"     </div>

                    <div class=""row mb-3"">
                      <label for=""Linkedin"" class=""col-md-4 col-lg-3 col-form-label"">Linkedin Profile</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""linkedin"" type=""text"" class=""form-control"" id=""Linkedin"" value=""https://linkedin.com/#"">
                      </div>
                    </div>

                    <div class=""text-center"">
                      <button type=""submit"" class=""btn btn-primary"">Save Changes</button>
                    </div>
                  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<!-- End Profile Edit Form -->\r\n\r\n                </div>\r\n\r\n                <div class=\"tab-pane fade pt-3\" id=\"profile-settings\">\r\n\r\n                  <!-- Settings Form -->\r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebf19fcf102b7adcd4c402ecd4e6ec33868b6e7724955", async() => {
                WriteLiteral(@"

                    <div class=""row mb-3"">
                      <label for=""fullName"" class=""col-md-4 col-lg-3 col-form-label"">Email Notifications</label>
                      <div class=""col-md-8 col-lg-9"">
                        <div class=""form-check"">
                          <input class=""form-check-input"" type=""checkbox"" id=""changesMade"" checked>
                          <label class=""form-check-label"" for=""changesMade"">
                            Changes made to your account
                          </label>
                        </div>
                        <div class=""form-check"">
                          <input class=""form-check-input"" type=""checkbox"" id=""newProducts"" checked>
                          <label class=""form-check-label"" for=""newProducts"">
                            Information on new products and services
                          </label>
                        </div>
                        <div class=""form-check"">
                          <input cl");
                WriteLiteral(@"ass=""form-check-input"" type=""checkbox"" id=""proOffers"">
                          <label class=""form-check-label"" for=""proOffers"">
                            Marketing and promo offers
                          </label>
                        </div>
                        <div class=""form-check"">
                          <input class=""form-check-input"" type=""checkbox"" id=""securityNotify"" checked disabled>
                          <label class=""form-check-label"" for=""securityNotify"">
                            Security alerts
                          </label>
                        </div>
                      </div>
                    </div>

                    <div class=""text-center"">
                      <button type=""submit"" class=""btn btn-primary"">Save Changes</button>
                    </div>
                  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<!-- End settings Form -->\r\n\r\n                </div>\r\n\r\n                <div class=\"tab-pane fade pt-3\" id=\"profile-change-password\">\r\n                  <!-- Change Password Form -->\r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebf19fcf102b7adcd4c402ecd4e6ec33868b6e7728377", async() => {
                WriteLiteral(@"

                    <div class=""row mb-3"">
                      <label for=""currentPassword"" class=""col-md-4 col-lg-3 col-form-label"">Current Password</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""password"" type=""password"" class=""form-control"" id=""currentPassword"">
                      </div>
                    </div>

                    <div class=""row mb-3"">
                      <label for=""newPassword"" class=""col-md-4 col-lg-3 col-form-label"">New Password</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""newpassword"" type=""password"" class=""form-control"" id=""newPassword"">
                      </div>
                    </div>

                    <div class=""row mb-3"">
                      <label for=""renewPassword"" class=""col-md-4 col-lg-3 col-form-label"">Re-enter New Password</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""rene");
                WriteLiteral(@"wpassword"" type=""password"" class=""form-control"" id=""renewPassword"">
                      </div>
                    </div>

                    <div class=""text-center"">
                      <button type=""submit"" class=""btn btn-primary"">Change Password</button>
                    </div>
                  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<!-- End Change Password Form -->\r\n\r\n                </div>\r\n\r\n              </div><!-- End Bordered Tabs -->\r\n\r\n            </div>\r\n          </div>\r\n\r\n        </div>\r\n      </div>\r\n    </section>\r\n\r\n  </main><!-- End #main -->");
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