using Project01.Core.Common;

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServices(builder.Configuration);
builder.Services.AddConfigurations(builder.Configuration);

var app = builder.Build();

app.UseServices();

app.Run();
