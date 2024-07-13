using Application.Interfaces;
using Application.IRepository;
using Application.IServices;
using Application.Services;
using Infrastracture;
using Infrastracture.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Infrastructure
{

    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration) {

            string? con = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(con));
            //dependency injection contanaireS
            services.AddScoped<ISupervisorRepository, SupervisorRepository>();
            services.AddScoped<ISupervisorService, SupervisorService>();
            services.AddScoped<IExamRepository, ExamRepository>();
            services.AddScoped<IGradeRepository, GradeRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
