using System;
using GrpcApiGw_Test.Contracts;
using GrpcApiGw_Test.Controller;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using GrpcApiGw_Test.Services;
using Microsoft.OpenApi.Models;

namespace GrpcApiGw_Test
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            bool _IsGrpc = false;
            services.AddGrpcHttpApi();
            services.AddGrpc();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GrpcApiGw_Api", Version = "v1" });
            });
            services.AddGrpcSwagger();

            services.AddScoped<ICustomerController, CustomerController>();
            if (_IsGrpc)
            {
                services.AddScoped<ICustomerGrpcClient, CustomerGrpcClient>(s => new CustomerGrpcClient(new Uri("http://grpcservice_test:55001")));
                services.AddScoped<ICustomerApiClient, CustomerApiClient>(s => new CustomerApiClient(new Uri("http://grpcservice_test:55001")));
            }
            else
            {
                services.AddScoped<ICustomerGrpcClient, CustomerGrpcClient>(s => new CustomerGrpcClient(new Uri("http://grpcservice_test:55001")));
                services.AddScoped<ICustomerApiClient, CustomerApiClient>(s => new CustomerApiClient(new Uri("http://grpcservice_test:55001")));
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "GrpcApiGw_Api V1");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<CustomerService>();
            });
        }
    }
}