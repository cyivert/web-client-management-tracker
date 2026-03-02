// File : Program.cs

using web_client_management_tracker.Components;
using web_client_management_tracker.Models;

WebApplicationBuilder appBuilder = WebApplication.CreateBuilder(args);

// Add services to the container.
appBuilder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register the ClientService as a singleton service in the dependency injection container
appBuilder.Services.AddSingleton<ClientService>();

WebApplication app = appBuilder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();
app.UseAntiforgery();
app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
