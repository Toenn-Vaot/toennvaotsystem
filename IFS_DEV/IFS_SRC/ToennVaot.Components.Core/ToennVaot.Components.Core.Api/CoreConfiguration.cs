using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ToennVaot.Components.Core.Api.Profiles;

namespace ToennVaot.Components.Core.Api
{
    /// <summary>
    /// Class configuration usage, used from the host class
    /// </summary>
    public class CoreConfiguration
    {
        /// <summary>
        /// Configure the service dependency injections
        /// </summary>
        /// <param name="services">The service collection instance</param>
        /// <param name="configuration">The configuration instance</param>
        /// <param name="currentEnvironment"></param>
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration, IWebHostEnvironment currentEnvironment)
        {
        }

        /// <summary>
        ///     Method to get the auto-mapper profiles to load
        /// </summary>
        /// <returns>The list of mapping profiles</returns>
        public static List<Profile> GetMappingProfiles()
        {
            return new List<Profile>
            {
                new CoreProfile()
            };
        }
    }
}
