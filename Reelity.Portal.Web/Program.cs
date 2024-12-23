// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Reelity.Portal.Web;
using Reelity.Portal.Web.Brokers.API;
using Reelity.Portal.Web.Brokers.DateTimes;
using Reelity.Portal.Web.Brokers.Logging;
using Reelity.Portal.Web.Brokers.Loggings;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

        AddRootDirectory(builder);
        builder.Services.AddHttpClient();
        builder.Services.AddScoped<IApiBroker, ApiBroker>();
        builder.Services.AddScoped<ILogger, Logger<LoggingBroker>>();
        builder.Services.AddScoped<ILoggingBroker, LoggingBroker>();
        builder.Services.AddScoped<IDateTimeBroker, DateTimeBroker>();


        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error", createScopeForErrors: true);
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();
        app.UseAntiforgery();

        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        app.Run();
    }

    private static void AddRootDirectory(WebApplicationBuilder builder)
    {
        builder.Services.AddRazorPages(options =>
        {
            options.RootDirectory = "/Views/Pages";
        });
    }
}