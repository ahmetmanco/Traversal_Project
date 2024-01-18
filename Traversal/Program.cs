using BussinessLayer.Ext;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Traversal.Models;
using Microsoft.Extensions.Hosting;
using Traversal.CQRS.Handlers.DestinationHandler;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLogging(x=>
{
    x.ClearProviders();
    x.SetMinimumLevel(LogLevel.Debug);
    x.AddDebug();
});

builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>()
    .AddEntityFrameworkStores<Context>()
    .AddErrorDescriber<CustomIdentityValidator>()
    .AddEntityFrameworkStores<Context>();

builder.Services.AddScoped<GetDestinationByIdQueryHandler>();
builder.Services.AddScoped<GetAllDestinationQueryHandler>();
builder.Services.AddFluentValidation();

builder.Services.ExtDependency();
builder.Services.CustomValidator();
// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

builder.Services.AddHttpClient();
builder.Services.AddAutoMapper(typeof(Program).Assembly);



builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddMvc();
var app = builder.Build();


//var path = Directory.GetCurrentDirectory();
app.Services.GetRequiredService<ILoggerFactory>().AddFile("Logs/mylog-{Date}.txt");
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");
app.UseHttpsRedirection();
app.UseStaticFiles();

//if(!app.Environment.IsDevelopment())
//{
//    app.UseSpaStaticFiles();
    
//}

app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

app.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.UseSpa(spa =>
//{
//    spa.Options.SourcePath = "ClientApp";

//    if (app.Environment.IsDevelopment())
//    {
//       //spa.UseAngularCliServer(npmScript: "start");
//        spa.UseProxyToSpaDevelopmentServer("http://localhost:5016");
//    }
//});

app.Run();
