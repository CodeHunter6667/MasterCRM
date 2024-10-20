using MasterCRM;
using MasterCRM.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

Configuration.ConnectionString = builder.Configuration.GetConnectionString("SqlConnection") ?? string.Empty;
builder.Services.AddDbContext<AppDBContext>(
    options => options.UseNpgsql(Configuration.ConnectionString)
);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x => { x.CustomSchemaIds(n => n.FullName); });
var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI();

app.MapControllers();

app.Run();
