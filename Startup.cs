using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using ServicesOnLineAPI.Models.DataManager;
using ServicesOnLineAPI.Models.DataTransferObject;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Swashbuckle.AspNetCore.Swagger;
using ServicesOnLineAPI.Models.Inputs;

namespace ServicesOnLineAPI
{
     public class Startup
     {
          public Startup(IConfiguration configuration)
          {
               Configuration = configuration;
          }

          public IConfiguration Configuration { get; }

          // This method gets called by the runtime. Use this method to add services to the container.
          public void ConfigureServices(IServiceCollection services)
          {
               services.AddDbContext<DataAccessContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:ServicesOnLineDb"]));
               
               services.AddScoped<IDataRepository          <Person, PersonDto  >, PersonDataManager>();
               services.AddScoped<IDataRepositoryForUpdates<Person, PersonInput>, PersonDataManager>();

               services.AddScoped<IDataRepository<Role, RoleDto>, RoleDataManager>();
               services.AddScoped<IDataRepository<PersonsRole, PersonsRoleDto>, PersonsRoleDataManager>();
               services.AddScoped<IDataRepository<Entity, EntityDto>, EntityDataManager>();
               services.AddScoped<IDataRepository<Entity, EntityDto>, EntityDataManager>();
               services.AddScoped<IDataRepository<Service, ServiceDto>, ServiceDataManager>();
               services.AddScoped<IDataRepository<GeoRegion, GeoRegionDto>, GeoRegionDataManager>();
               services.AddScoped<IDataRepository<GeoCity, GeoCityDto>, GeoCityDataManager>();
               services.AddScoped<IDataRepository<ServicesType, ServicesTypeDto>, ServicesTypeDataManager>();
               services.AddScoped<IDataRepository<UnitOfMeasure, UnitOfMeasureDto>, UnitOfMeasureDataManager>();
               services.AddScoped<IDataRepository<PriceList, PriceListDto>, PriceListDataManager>();
               services.AddScoped<IDataRepository<ServiceSched, ServiceSchedDto>, ServiceSchedDataManager>();
               services.AddScoped<IDataRepository<Promotion, PromotionDto>, PromotionDataManager>();
               services.AddScoped<IDataRepository<ServiceMedia, ServiceMediaDto>, ServiceMediaDataManager>();
               services.AddScoped<IDataRepository<ShoppingCart, ShoppingCartDto>, ShoppingCartDataManager>();
               services.AddScoped<IDataRepository<Location, LocationDto>, LocationDataManager>();
               services.AddScoped<IDataRepository<LocationsType, LocationTypeDto>, LocationTypeManager>();
               services.AddScoped<IDataRepository<TransactState, TransactStateDto>, TransactStateDataManager>();
               services.AddScoped<IDataRepository<OrdersHeader, OrdersHeaderDto>, OrdersHeaderDataManager>();
               services.AddScoped<IDataRepository<Cctransaction, CctransactionDto>, CctransactionDataManager>();
               services.AddScoped<IDataRepository<Order, OrderDto>, OrderDataManager>();
               services.AddScoped<IDataRepository<PaymentHist, PaymentHistDto>, PaymentHistDataManager> ();
               services.AddScoped<IDataRepository<Address, AddressDto>, AddressDataManager>();


               services.AddControllers().AddNewtonsoftJson(
               options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
               );

               services.AddAutoMapper(typeof(Startup));

               services.AddControllers();

               services.AddSwaggerGen(c => {
                    c.SwaggerDoc("v1", new OpenApiInfo { Title = "ServicesOnLineAPI", Version = "v1" });
               });


          }

          // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
          public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
          {
               if (env.IsDevelopment())
               {
                    app.UseDeveloperExceptionPage();
                    //Enable middleware to serve generate Swagger as JSON endpoing
                    app.UseSwagger();

                    //Enable middleware to serve swagger-iu (HTML, JS, CSS, etc.),
                    //specifyin the Swagger JSON endpoing.
                    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ServicesOnLineAPI v1"));
               }

               app.UseHttpsRedirection();

               app.UseRouting();

               app.UseAuthorization();

               //app.UseEndpoints(endpoints =>
               //{
               //     endpoints.MapControllers();
               //});

               //This will make the Swager index page to appear when deployex in the IIS
               app.UseSwaggerUI(c =>
               {
                    string swaggerJsonBasePath = string.IsNullOrWhiteSpace(c.RoutePrefix) ? "." : "..";
                    c.SwaggerEndpoint($"{swaggerJsonBasePath}/swagger/v1/swagger.json", "ServicesOnLine");

               });

               app.UseEndpoints(endpoints =>
               {
                    endpoints.MapControllerRoute(
                         name: "default",
                         pattern: "{controller=Home}/{action=Index}/{id?}");
               });
          }
     }
}
