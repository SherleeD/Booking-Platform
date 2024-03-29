using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using NSwag.AspNetCore;
using System.Reflection;

using Booking.Persistence;

using Booking.Application.Room.Queries.GetRoomDetail;
using Booking.Application.Room.Queries.GetRoomList;
using Booking.Application.Room.Commands.CreateRoom;
using Booking.Application.Room.Commands.UpdateRoom;
using Booking.Application.Room.Commands.DeleteRoom;

using Booking.Application.RoomRental.Queries.GetRoomRentalDetail;
using Booking.Application.RoomRental.Queries.GetRoomRentalList;
using Booking.Application.RoomRental.Commands.CreateRoomRental;
using Booking.Application.RoomRental.Commands.UpdateRoomRental;
using Booking.Application.RoomRental.Commands.DeleteRoomRental;
using Booking.Application.RoomRental.Queries.GetAvailableRoom;


namespace Booking.Presentation
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
            services.AddDbContext<BookingContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("BookingConnectionString")));

            services.AddScoped<IGetRoomDetailQuery, GetRoomDetailQuery>();
            services.AddScoped<IGetRoomListQuery, GetRoomListQuery>();
            services.AddScoped<ICreateRoomCommand, CreateRoomCommand>();            
            services.AddScoped<IDeleteRoomCommand, DeleteRoomCommand>();
            services.AddScoped<IUpdateRoomCommand, UpdateRoomCommand>();

            services.AddScoped<IGetRoomRentalDetailQuery, GetRoomRentalDetailQuery>();
            services.AddScoped<IGetRoomRentalListQuery, GetRoomRentalListQuery>();
            services.AddScoped<ICreateRoomRentalCommand, CreateRoomRentalCommand>();
            services.AddScoped<IDeleteRoomRentalCommand, DeleteRoomRentalCommand>();
            services.AddScoped<IUpdateRoomRentalCommand, UpdateRoomRentalCommand>();
            services.AddScoped<IGetAvailableRoomListQuery, GetAvailableRoomListQuery>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // In production, the Angular files will be served from this directory
            //services.AddSpaStaticFiles(configuration =>
            //{
            //    configuration.RootPath = "ClientApp/dist";
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, BookingContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                //{
                //    HotModuleReplacement = true
                //});

                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseExceptionHandler("/Error");
            }
            
            //app.UseSwaggerUi(typeof(Startup).GetTypeInfo().Assembly, new SwaggerUiSettings
            //{
            //    DefaultUrlTemplate = "{controller}/{action}/{id?}"
            //});


            app.UseStaticFiles();
            //app.UseSpaStaticFiles();

            //app.UseMvc();
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            //app.UseSpa(spa =>
            //{
            //    // To learn more about options for serving an Angular SPA from ASP.NET Core,
            //    // see https://go.microsoft.com/fwlink/?linkid=864501

            //    spa.Options.SourcePath = "ClientApp";

            //    if (env.IsDevelopment())
            //    {
            //        spa.UseAngularCliServer(npmScript: "start");
            //    }
            //});


            //uncomment when I apply swagger
            //app.MapWhen(a => !a.Request.Path.Value.StartsWith("/swagger"), builder =>
            //    builder.UseMvc(routes =>
            //    {
            //        routes.MapSpaFallbackRoute(
            //            name: "spa-fallback",
            //            defaults: new { controller = "Home", action = "Index" });
            //    })
            //);

            BookingInitializer.Initialize(context);

        }
    }
}
