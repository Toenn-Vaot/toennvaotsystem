using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace ToennVaot.Components.Core.Api
{
    /// <summary>
    /// The API Configuration base class
    /// </summary>
    public static class ApiConfigurationBase
    {
        /// <summary>
        /// Configure API with the minimum services to use
        /// </summary>
        /// <param name="app">The application builder instance</param>
        /// <param name="env">The hosting environment</param>
        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(builder => { builder.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod(); });
            app.UseResponseCompression(); //Must be before UseStaticFiles() to compress static files too
            app.UseStaticFiles();
            app.UseHttpsRedirection();
        }
    }
}
