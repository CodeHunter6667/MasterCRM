using MasterCRM.Common;

var builder = WebApplication.CreateBuilder(args);

builder.AddConfigurations();
builder.AddDataContexts();
builder.AddDocumentation();
builder.AddServices();
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.UseSwagger();

app.UseSwaggerUI();

app.Run();
