using AdminTemplate.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSyncfusionBlazor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzY4NzcyQDMyMzAyZTMzMmUzMFdvU1ArbE9rTDRKVWhoTjZjNlRIZTRlbUtvMVkwOEhmSkI1b2dubTNRSDQ9");

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
