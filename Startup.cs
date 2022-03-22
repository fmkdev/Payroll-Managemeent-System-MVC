using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using PayxApi.Auth;
using PayxApi.ContextDb;
using PayxApi.Implementations.Repositories;
using PayxApi.Implementations.Services;
using PayxApi.Interfaces.Repositories;
using PayxApi.Interfaces.Services;

namespace PayxApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            
            services.AddControllersWithViews();
            services.AddHostedService<PayXBackgroundTasks>();
            
            services.AddDbContext<ContextApp>(options => 
            options.UseMySQL(Configuration.GetConnectionString("ContextApp")));
            

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeService, EmployeeService>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IRoleService, RoleService>();

            services.AddScoped<IPositionRepository, PositionRepository>();
            services.AddScoped<IPositionService, PositionService>();

            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IDepartmentService, DepartmentService>();

            services.AddScoped<IWorkingDaysRepository, WorkingDaysRepository>();
            services.AddScoped<IWorkingDaysService, WorkingDaysService>();

            services.AddScoped<IAccountDetailsRepository, AccountDetailsRepository>();
            services.AddScoped<IAccountDetailsService, AccountDetailsService>();

            services.AddScoped<IAllowanceRepository, AllowanceRepository>();
            services.AddScoped<IAllowanceService, AllowanceService>();

            services.AddScoped<IPayLevelRepository, PayLevelRepository>();
            services.AddScoped<IPayLevelService, PayLevelService>();

            services.AddScoped<IPayrollRepository, PayrollRepository>();
            services.AddScoped<IPayrollService, PayrollService>();

            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IAddressService, AddressService>();

            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            services.AddScoped<IAppointmentService, AppointmentService>();

            services.AddScoped<IBonusRepository, BonusRepository>();
            services.AddScoped<IBonusService, BonusService>();

            services.AddScoped<IOtherDeductionRepository, OtherDeductionRepository>();
            services.AddScoped<IOtherDeductionService, OtherDeductionService>();

            services.AddScoped<ITaxRepository, TaxRepository>();
            services.AddScoped<ITaxService, TaxService>();


            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(config =>
                {
                    config.LoginPath = "/User/login";
                    config.Cookie.Name = "PayX";
                    config.LogoutPath = "/User/logout";
                });
            services.AddAuthorization();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=User}/{action=Login}/{id?}");
            });
        }
    }
}
