using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Agri_Connect_Platform.Data;
using System;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
    options.User.RequireUniqueEmail = true; // Ensure unique emails for each user
})
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultUI(); // Enable default UI for Identity

builder.Services.Configure<IdentityOptions>(options =>
{
    // Configure identity options here, if needed
});

builder.Services.ConfigureApplicationCookie(options =>
{
    // Cookie settings
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(30);

    options.LoginPath = "/Account/Login"; // Customize login path
    options.AccessDeniedPath = "/Account/AccessDenied"; // Customize access denied path
    options.SlidingExpiration = true;
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("FarmerPolicy", policy => policy.RequireRole("Farmer"));
    options.AddPolicy("EmployeePolicy", policy => policy.RequireRole("Employee"));
});

builder.Services.AddControllersWithViews();

// Initialize Firebase Admin SDK
var serviceAccount = GoogleCredential.FromFile("Firebase/serviceAccountKey.json");
FirestoreDb db = new FirestoreDbBuilder
{
    ProjectId = "agri-energy-connect-f5b07",
    CredentialsPath = "Firebase/serviceAccountKey.json"
}.Build();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
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

app.UseAuthentication(); // Enable authentication
app.UseAuthorization(); // Enable authorization

// Configure additional middleware or services conditionally based on authentication
app.Use(async (context, next) =>
{
    if (context.User.Identity.IsAuthenticated)
    {
        // Add middleware or configure services here for authenticated users

        // Check user roles and configure services accordingly
        if (context.User.IsInRole("Farmer"))
        {
            // Additional services or middleware for Farmer role
        }
        else if (context.User.IsInRole("Employee"))
        {
            // Additional services or middleware for Employee role
        }
    }

    await next();
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
