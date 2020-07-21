using AutoMapper;
using KingICT.Academy.Contract;
using KingICT.Academy.Model.Repositories;
using KingICT.Academy.Repository;
using KingICT.Academy.Service;
using KingICT.Academy.Service.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KingICT.Academy.IoC
{
    public static class ServiceConfiguration
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            ConfigureApplicationServices(services);
            ConfigureRepositories(services, configuration);
        }

        private static void ConfigureApplicationServices(IServiceCollection services)
        {
            services.AddTransient<ICourseService, CourseService>();
            services.AddTransient<IStudentService, StudentService>();


            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new CourseMappingProfile());
                mc.AddProfile(new StudentMappingProfile());
            });

            services.AddSingleton(mappingConfig.CreateMapper());
        }

        private static void ConfigureRepositories(IServiceCollection services, IConfiguration configuration)
        {
            var dbConfig = configuration.GetSection(nameof(DbConfig)).Get<DbConfig>();
            services.AddDbContext<AcademyDbContext>(options =>
            {
                options.UseSqlServer(dbConfig.ConnectionString);
            });

            services.AddTransient<ICourseRepository, CourseRepository>();

            services.AddTransient<IStudentRepository, StudentRepository>();
        }
    }
}
