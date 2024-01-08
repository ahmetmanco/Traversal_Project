using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EF;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Traversal.Models;

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

builder.Services.AddScoped<ICommentService, CommentManager>();
builder.Services.AddScoped<ICommentDal, EFCommentDal>();

builder.Services.AddScoped<IDestinationService, DestinationManager>();
builder.Services.AddScoped<IDestinationDal, EFDestinationDal>();

builder.Services.AddScoped<IAppUserDal, EFAppUserDal>();
builder.Services.AddScoped<IAppUserService, AppUserManager>();

builder.Services.AddScoped<IRezervasyonService, RezervasyonManager>();
builder.Services.AddScoped<IRezervasyonDal, EFRezervasyonDal>();

builder.Services.AddScoped<IGuideService, GuideManager>();
builder.Services.AddScoped<IPdfService, PdfManager>();

builder.Services.AddScoped<IExcelService, ExcelManager>();
builder.Services.AddScoped<IGuidDal, EFGuideDal>();
// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation(); ;

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

app.Run();
