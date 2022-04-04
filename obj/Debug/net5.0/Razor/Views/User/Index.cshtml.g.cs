#pragma checksum "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccfa2e288757b4548a01eada01c647db87918097"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccfa2e288757b4548a01eada01c647db87918097", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81b62c4faf6c87acb2157b7b144752dde1bc2e99", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PayxApi.DTOs.UserDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Index.cshtml"
  
    Layout = "_PayxLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    
  
<main id=""main"" class=""main"">

    <div class=""pagetitle"">
      <h1>Dashboard</h1>
      <nav>
        <ol class=""breadcrumb"">
          <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
          <li class=""breadcrumb-item active"">Dashboard</li>
        </ol>
      </nav>
    </div><!-- End Page Title -->

    <section class=""section dashboard"">
      <div class=""row"">

        <!-- Left side columns -->
        <div class=""col-lg-8"">
          <div class=""row"">

            <!-- Sales Card -->
            <div class=""col-xxl-4 col-md-6"">
              <div class=""card info-card sales-card"">

                <div class=""filter"">
                  <a class=""icon"" href=""#"" data-bs-toggle=""dropdown""><i class=""bi bi-three-dots""></i></a>
                  <ul class=""dropdown-menu dropdown-menu-end dropdown-menu-arrow"">
                    <li class=""dropdown-header text-start"">
                      <h6>Filter</h6>
                    </li>

                ");
            WriteLiteral(@"    <li><a class=""dropdown-item"" href=""#"">Today</a></li>
                    <li><a class=""dropdown-item"" href=""#"">This Month</a></li>
                    <li><a class=""dropdown-item"" href=""#"">This Year</a></li>
                  </ul>
                </div>

                <div class=""card-body"">
                  <h5 class=""card-title"">Employeess <span>| Including All the Official Staff</span></h5>

                  <div class=""d-flex align-items-center"">
                    <div class=""card-icon rounded-circle d-flex align-items-center justify-content-center"">
                      <i class=""bi bi-people""></i>
                    </div>
                    <div class=""ps-3"">
                      <h6 id=""total-employee""></h6>
                      <span class=""text-success small pt-1 fw-bold""></span> <span class=""text-muted small pt-2 ps-1""></span>

                    </div>
                  </div>
                </div>

              </div>
            </div><!-- End Sales Card ");
            WriteLiteral(@"-->

            <!-- Revenue Card -->
            <div class=""col-xxl-4 col-md-6"">
              <div class=""card info-card revenue-card"">

                <div class=""filter"">
                  <a class=""icon"" href=""#"" data-bs-toggle=""dropdown""><i class=""bi bi-three-dots""></i></a>
                  <ul class=""dropdown-menu dropdown-menu-end dropdown-menu-arrow"">
                    <li class=""dropdown-header text-start"">
                      <h6>Filter</h6>
                    </li>

                    <li><a class=""dropdown-item"" href=""#"">Today</a></li>
                    <li><a class=""dropdown-item"" href=""#"">This Month</a></li>
                    <li><a class=""dropdown-item"" href=""#"">This Year</a></li>
                  </ul>
                </div>

                <div class=""card-body"">
                  <h5 class=""card-title"">Department <span>| All Department</span></h5>

                  <div class=""d-flex align-items-center"">
                    <div class=""card-icon round");
            WriteLiteral(@"ed-circle d-flex align-items-center justify-content-center"">
                      <i class=""bi bi-people""></i>
                    </div>
                    <div class=""ps-3"">
                      <h6 id=""all-department""></h6>
                      <span class=""text-success small pt-1 fw-bold""></span> <span class=""text-muted small pt-2 ps-1""></span>

                    </div>
                  </div>
                </div>

              </div>
            </div><!-- End Revenue Card -->

            <!-- Customers Card -->
            <div class=""col-xxl-4 col-xl-12"">

              <div class=""card info-card customers-card"">

                <div class=""filter"">
                  <a class=""icon"" href=""#"" data-bs-toggle=""dropdown""><i class=""bi bi-three-dots""></i></a>
                  <ul class=""dropdown-menu dropdown-menu-end dropdown-menu-arrow"">
                    <li class=""dropdown-header text-start"">
                      <h6>Filter</h6>
                    </li>

       ");
            WriteLiteral(@"             <li><a class=""dropdown-item"" href=""#"">Today</a></li>
                    <li><a class=""dropdown-item"" href=""#"">This Month</a></li>
                    <li><a class=""dropdown-item"" href=""#"">This Year</a></li>
                  </ul>
                </div>

                <div class=""card-body"">
                  <h5 class=""card-title"">Weekly <span>| Last Weekly Reinbursement</span></h5>

                  <div class=""d-flex align-items-center"">
                    <div class=""card-icon rounded-circle d-flex align-items-center justify-content-center"">
                      <i class=""bi bi-currency-dollar""></i>
                    </div>
                    <div class=""ps-3"">
                      <h6 id=""last-weekly-payment""></h6>
                      <span class=""text-danger small pt-1 fw-bold""></span> <span class=""text-muted small pt-2 ps-1""></span>

                    </div>
                  </div>
                <div class=""card-body"">
                  <h5 class=""card-");
            WriteLiteral(@"title"">Bi-Weekly <span>| Last Bi-Weekly Reinbursement</span></h5>

                  <div class=""d-flex align-items-center"">
                    <div class=""card-icon rounded-circle d-flex align-items-center justify-content-center"">
                      <i class=""bi bi-currency-dollar""></i>
                    </div>
                    <div class=""ps-3"">
                      <h6 id=""last-biweekly-payment""></h6>
                      <span class=""text-danger small pt-1 fw-bold""></span> <span class=""text-muted small pt-2 ps-1""></span>

                    </div>
                  </div>
                <div class=""card-body"">
                  <h5 class=""card-title"">Monthly <span>| Last Monthly Reinbursement</span></h5>

                  <div class=""d-flex align-items-center"">
                    <div class=""card-icon rounded-circle d-flex align-items-center justify-content-center"">
                      <i class=""bi bi-currency-dollar""></i>
                    </div>
                    ");
            WriteLiteral(@"<div class=""ps-3"">
                      <h6 id=""last-monthly-payment""></h6>
                      <span class=""text-danger small pt-1 fw-bold""></span> <span class=""text-muted small pt-2 ps-1""></span>

                    </div>
                  </div>

                </div>
              </div>

            </div><!-- End Customers Card -->

            
          </div>
        </div><!-- End Left side columns -->

        
        
          <div class=""card"">
            <div class=""card-body"">
              <h5 class=""card-title"">Bar CHart</h5>

              <!-- Bar Chart -->
              <canvas id=""barChart"" style=""max-height: 400px;""></canvas>
              <script>
                var mn =  ");
#nullable restore
#line 173 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Index.cshtml"
                     Write(Html.Raw(Json.Serialize(ViewBag.DEPARTMENTNAMES)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                var fn =  ");
#nullable restore
#line 174 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Index.cshtml"
                     Write(Html.Raw(Json.Serialize(ViewBag.EMPLOYEENUMBERS)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
                
                alert(mn);
                alert(fn);

                document.addEventListener(""DOMContentLoaded"", () => {
                  new Chart(document.querySelector('#barChart'), {
                    type: 'bar',
                    data: {
                      labels: mn,
                      datasets: [{
                        label: 'Employees',
                        data: fn,
                        backgroundColor: [
                          'rgba(255, 99, 132, 0.2)',
                          'rgba(255, 159, 64, 0.2)',
                          'rgba(255, 205, 86, 0.2)',
                          'rgba(75, 192, 192, 0.2)',
                          'rgba(54, 162, 235, 0.2)',
                          'rgba(153, 102, 255, 0.2)',
                          'rgba(201, 203, 207, 0.2)'
                        ],
                        borderColor: [
                          'rgb(255, 99, 132)',
                          'rgb(255, 159, 64)',
     ");
            WriteLiteral(@"                     'rgb(255, 205, 86)',
                          'rgb(75, 192, 192)',
                          'rgb(54, 162, 235)',
                          'rgb(153, 102, 255)',
                          'rgb(201, 203, 207)'
                        ],
                        borderWidth: 1
                      }]
                    },
                    options: {
                      scales: {
                        y: {
                          beginAtZero: true
                        }
                      }
                    }
                  });
                });
              </script>
              
              <!-- End Bar CHart -->

            </div>
          </div>


      </div>
    </section>

  </main><!-- End #main -->
  <script>
    const emp = document.querySelector(""#total-employee"");
    const weekly = document.querySelector(""#last-weekly-payment"");
    const biweekly = document.querySelector(""#last-biweekly-payment"");
    const month");
            WriteLiteral(" = document.querySelector(\"#last-monthly-payment\");\r\n    const dept = document.querySelector(\"#all-department\");\r\n\r\n    var totalEmployee = ");
#nullable restore
#line 236 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Index.cshtml"
                   Write(ViewBag.EMPLOYEES);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var depts = ");
#nullable restore
#line 237 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Index.cshtml"
           Write(ViewBag.DEPARTMENT);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var weeklyAmount = ");
#nullable restore
#line 238 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Index.cshtml"
                  Write(ViewBag.WEEKLY);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var biweeklyAmount = ");
#nullable restore
#line 239 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Index.cshtml"
                    Write(ViewBag.BIWEEK);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var monthlylyAmount = ");
#nullable restore
#line 240 "C:\Users\fmkDev\Desktop\Testing\PayxApi\Views\User\Index.cshtml"
                     Write(ViewBag.MONTHLY);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    window.onload = function () {
          emp.innerText = totalEmployee;
          weekly.innerText = weeklyAmount;
          biweekly.innerText = biweeklyAmount;
          month.innerText = monthlylyAmount;
          dept.innerText = depts;              
        };
  </script>
  <script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
  <script type=""text/javascript"">
  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PayxApi.DTOs.UserDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
