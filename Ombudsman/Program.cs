using Ombudsman.Api.Middleware;
using Ombudsman.BizLogicLayer;
using Ombudsman.Core;
using Ombudsman.DataLayer;

namespace Ombudsman
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services
           .AddApis(builder.Configuration)
           .AddDataLayer(builder.Configuration)
           .AddCoreLayer(builder.Configuration)
           .AddBizLogicLayer();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if(app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseMiddleware<UserMiddleware>();

            app.MapControllers();

            app.Run();
        }
    }
}