﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Models;
using PainTrackerPT.Common.Medicine;
using PainTrackerPT.Services;
using PainTrackerPT.Repository;
using PainTrackerPT.Data.Medicine.APIClasses;
using System.Data.SqlClient;
using PainTrackerPT.Common.Followups;
using PainTrackerPT.Data.Followups;
using System.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Net.Http.Headers;
using PainTrackerPT.Data.Followups;
using PainTrackerPT.Data.Followups.Repository;
using PainTrackerPT.Data.Followups.Services;
using PainTrackerPT.Models.Followups;
using SameSiteMode = Microsoft.AspNetCore.Http.SameSiteMode;

namespace PainTrackerPT
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

         

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContext<PainTrackerPTContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("PainTrackerPTContext")));           

            // Just for testing use the in memory database but in real testing, create  your own one.
            //options.UseInMemoryDatabase("PainTrackerPTContext"));

            services.AddScoped(typeof(IMedicineLog<>), typeof(MedicineRepository<>));
            services.AddScoped(typeof(IMedicineService<>), typeof(MedicineService<>));
            services.AddScoped(typeof(IMedicineIntakeEventAPI), typeof(MedicineIntakeEventAPI));
            services.AddScoped(typeof(IMedicineDataAPI), typeof(MedicineDataAPI));
            services.AddScoped(typeof(IMediaService), typeof(MediaService));
           // services.AddScoped<PainTrackerPTContext>(_context => new PainTrackerPTContext());

            // services.AddDbContext<PainTrackerPTContext>(options =>
            //         options.UseSqlServer(Configuration.GetConnectionString("PainTrackerPTContext")));

            services.AddScoped<SqlConnection>(db => new SqlConnection(Configuration.GetConnectionString("PainTrackerPTContext")));

                    options.UseSqlServer(Configuration.GetConnectionString("PainTrackerPTContext")));

            services.AddScoped<SqlConnection>(db => new SqlConnection(Configuration.GetConnectionString("PainTrackerPTContext")));

            /** Team Team's (FollowUps) Services**/
//            services.AddScoped(typeof(IBaseService <>), typeof(BaseService <>));
            services.TryAddTransient<IBaseService<Advice>, AdviceService>();
            services.TryAddTransient<IBaseService<Answer>, AnswerService>();
            services.TryAddTransient<IBaseService<FollowUp>, FollowUpService>();
            services.TryAddTransient<IBaseService<Media>, MediaService>();
            services.TryAddTransient<IBaseService<Question>, QuestionService>();
            services.TryAddTransient<IBaseService<Recommendation>, RecommendationService>();

            services.TryAddTransient<IBaseRepository<Advice>, AdviceRepository>();
            services.TryAddTransient<IBaseRepository<Answer>, AnswerRepository>();
            services.TryAddTransient<IBaseRepository<FollowUp>, FollowUpRepository>();
            services.TryAddTransient<IBaseRepository<Media>, MediaRepository>();
            services.TryAddTransient<IBaseRepository<Question>, QuestionRepository>();
            services.TryAddTransient<IBaseRepository<Recommendation>, RecommendationRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }


}
