using CrudAlunos.Application.Interfaces;
using CrudAlunos.Application.Services;
using CrudAlunos.Domain.Interfaces;
using CrudAlunos.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
namespace CrudAlunos.Infra.Ioc
{
    public static class DependencyInjection
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IAlunoRepository, AlunoRepository>();
            services.AddScoped<IAlunoService, AlunoService>();
        }
    }
}
