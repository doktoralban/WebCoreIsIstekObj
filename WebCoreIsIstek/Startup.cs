using WebCoreIsIstek.Application.Interfaces;
using WebCoreIsIstek.Application.Services;
using WebCoreIsIstek.Core;
using WebCoreIsIstek.Core.Interfaces;
using WebCoreIsIstek.Infrastructure.Logging;
using WebCoreIsIstek.Infrastructure.Data;
using WebCoreIsIstek.Infrastructure.Repository;
using WebCoreIsIstek.HealthChecks;
using WebCoreIsIstek.Interfaces;
using WebCoreIsIstek.Services;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebCoreIsIstek.Core.Repositories;
using WebCoreIsIstek.Core.Repositories.Base;
using WebCoreIsIstek.Core.Configuration;
using WebCoreIsIstek.Infrastructure.Repository.Base;

//WebCoreIsIstek


namespace WebCoreIsIstek
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
            //   dependencies
            ConfigureWebCoreIsIstekServices(services);

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.Lax;
            });

            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseRouting();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
                      {
                          endpoints.MapControllerRoute(
                              name: "default",
                              pattern: "{controller=Home}/{action=Index}/{id?}");
                      });
   

        //app.UseEndpoints(endpoints =>
        //  {
        //      endpoints.MapRazorPages();
        //  });
    }

        private void ConfigureWebCoreIsIstekServices(IServiceCollection services)
        {
            // Add Core Layer
            services.Configure<WebCoreIsIstekSettings>(Configuration);

            // Add Infrastructure Layer
            ConfigureDatabases(services);
            services.AddScoped(typeof( IRepository<>), typeof(Repository<>));
            //services.AddScoped<IProductRepository, ProductRepository>();
            //services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));

            //// Add Application Layer
            //services.AddScoped<IProductService, ProductService>();
            //services.AddScoped<ICategoryService, CategoryService>();

            //// Add Web Layer
           /* services.AddAutoMapper(typeof(Startup));*/ // Add AutoMapper
                                                     //services.AddScoped<IIndexPageService, IndexPageService>();
                                                     //services.AddScoped<IProductPageService, ProductPageService>();
                                                     //services.AddScoped<ICategoryPageService, CategoryPageService>();
//--------------------------------------------------------------------------
                var mvcviews = services.AddControllersWithViews();
    #if (DEBUG)
                mvcviews.AddRazorRuntimeCompilation();
#endif
//--------------------------------------------------------------------------

            // Add Miscellaneous
            services.AddHttpContextAccessor();
            services.AddHealthChecks()
                .AddCheck<IndexPageHealthCheck>("home_page_health_check");
        }

        public void ConfigureDatabases(IServiceCollection services)
        {
            //// use in-memory database
            //services.AddDbContext<AspnetRunContext>(c =>
            //    c.UseInMemoryDatabase("AspnetRunConnection"));

            // use real database
            services.AddDbContext<WebCoreIsIstekContext>(c =>
                c.UseSqlServer(Configuration.GetConnectionString("WebCoreIsIstekConnection")));
        }


        //*************************************************************
        //        public Startup(IConfiguration configuration)
        //        {
        //            Configuration = configuration;
        //        }

        //        public IConfiguration Configuration { get; }

        //        // This method gets called by the runtime. Use this method to add services to the container.
        //        public void ConfigureServices(IServiceCollection services)
        //        {
        //            ////.................................
        //            //var connectionTest = Configuration.GetConnectionString("cnnTestDb");
        //            //services.AddDbContext<TestDbContext>(opt => opt.UseSqlServer(connectionTest));
        //            ////.................................            
        //            //var connectionMakinaBakim = Configuration.GetConnectionString("cnnMakinaBakim");
        //            //services.AddDbContext<MakinaBakimDbContext>(opt => opt.UseSqlServer(connectionMakinaBakim));
        //            ////..........................................

        //            //services.AddDbContext<MakinaBakimDbContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("cnndbMakinaBakim")));
        //            ////*************************************************************
        //            //https://dev.to/expertsinside/turn-on-runtime-compilation-for-modified-views-in-asp-net-core-fbp
        //            var mvcviews = services.AddControllersWithViews();
        //            #if (DEBUG)
        //            mvcviews.AddRazorRuntimeCompilation();
        //#endif
        //            //*************************************************************
        //            //..........................................



        //        }

        //        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        //        {
        //            if (env.IsDevelopment())
        //            {
        //                app.UseDeveloperExceptionPage();
        //            }
        //            else
        //            {
        //                app.UseExceptionHandler("/Home/Error");
        //                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        //                app.UseHsts();
        //            }
        //            app.UseHttpsRedirection();
        //            app.UseStaticFiles();

        //            app.UseRouting();

        //            app.UseAuthorization();

        //            app.UseEndpoints(endpoints =>
        //            {
        //                endpoints.MapControllerRoute(
        //                    name: "default",
        //                    pattern: "{controller=Home}/{action=Index}/{id?}");
        //            });
        //        }

        //*************************************************************
















    }
}
