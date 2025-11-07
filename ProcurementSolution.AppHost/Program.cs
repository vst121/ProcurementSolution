using Microsoft.Extensions.Logging;

try
{
    var builder = DistributedApplication.CreateBuilder(args);

    // Add logging
    var logger = LoggerFactory.Create(config =>
    {
        config.AddConsole();
    }).CreateLogger("ProcurementSolution.AppHost");
    logger.LogInformation("Starting ProcurementSolution.AppHost");

    var notificationsApi = builder.AddProject("notifications-api", "../Procurement.Notifications.Api/Procurement.Notifications.Api.csproj");
    logger.LogInformation("Added notifications-api project");

    var ordersApi = builder.AddProject("orders-api", "../Procurement.Orders.Api/Procurement.Orders.Api.csproj");
    logger.LogInformation("Added orders-api project");

    builder.Build().Run();
}
catch (Exception ex)
{
    var logger = LoggerFactory.Create(config =>
    {
        config.AddConsole();
    }).CreateLogger("ProcurementSolution.AppHost");
    logger.LogError(ex, "An error occurred while starting the application");
    logger.LogError($"Exception type: {ex.GetType().FullName}");
    logger.LogError($"Inner exception: {ex.InnerException?.Message ?? "None"}");
    throw;
}
