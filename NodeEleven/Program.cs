using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using NodeEleven.Services.Steam;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient();
builder.Services.AddScoped<SteamService>();

builder.Services.AddSingleton<SteamService>(new SteamCached(
    new HttpClient
    {
        BaseAddress = new Uri(SteamSettings.RestApiLocation)
    }
    ));
//builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
/*
public void ConfigureServices(IServiceCollection services)
{

}
*/
app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
