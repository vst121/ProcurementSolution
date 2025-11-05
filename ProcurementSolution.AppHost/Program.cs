using Microsoft.Extensions.Logging;

var builder = DistributedApplication.CreateBuilder(args);

// Add logging
var logger = LoggerFactory.Create(config =>
{
    config.AddConsole();
}).CreateLogger("ProcurementSolution.AppHost");
logger.LogInformation("Starting ProcurementSolution.AppHost");

var notificationsApi = builder.AddProject("../Procurement.Notifications.Api/Procurement.Notifications.Api.csproj", "notifications-api");
logger.LogInformation("Added notifications-api project");

var ordersApi = builder.AddProject("../Procurement.Orders.Api/Procurement.Orders.Api.csproj", "orders-api");
logger.LogInformation("Added orders-api project");

builder.Build().Run();
