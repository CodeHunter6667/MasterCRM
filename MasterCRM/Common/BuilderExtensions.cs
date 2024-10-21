using MasterCRM.Data;
using MasterCRM.Services;
using MasterCRM.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MasterCRM.Common;
public static class BuilderExtensions
{
    public static void AddConfigurations(this WebApplicationBuilder builder)
    {
        Configuration.ConnectionString = builder.Configuration.GetConnectionString("SqlConnection") ?? string.Empty;
    }

    public static void AddServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IPessoaFisicaServico, PessoaFisicaServico>();
    }

    public static void AddDataContexts(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<AppDBContext>(
    options => options.UseNpgsql(Configuration.ConnectionString)
        );
    }

    public static void AddDocumentation(this WebApplicationBuilder builder)
    {
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(x => { x.CustomSchemaIds(n => n.FullName); });
    }
}
