using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace file_metadata
{
    public class Startup
    {
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddCors(options =>
			{
				options.AddDefaultPolicy(policy =>
				{
					policy.WithOrigins("https://www.freecodecamp.org");
					policy.WithMethods("POST");
					policy.AllowAnyHeader();
				});
			});
		}
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

			app.UseCors();
		}
    }
}
