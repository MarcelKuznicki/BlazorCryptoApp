using Blazored.LocalStorage;
using CryptoTrends.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddBlazoredLocalStorage();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode();

var config = builder.Configuration;

var coinGeckoBaseUrl = config["CoingeckoApi:BaseUrl"];
var coinGeckoApiKey = config["CoingeckoApi:ApiKey"];

//builder.Services.AddHttpClient("CoinGecko", client =>
//{
//    client.BaseAddress = new Uri(coinGeckoBaseUrl);
//    client.DefaultRequestHeaders.Add("accept", "application/json");
//    client.DefaultRequestHeaders.Add("x-cg-demo-api-key", coinGeckoApiKey);
//});

app.Run();
