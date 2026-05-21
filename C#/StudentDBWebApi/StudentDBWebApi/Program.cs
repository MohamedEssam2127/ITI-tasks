using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NLog.Web;
using StudentDBWebApi.Context;
using StudentDBWebApi.Filters;
using StudentDBWebApi.Middleware;
using StudentDBWebApi.Models;
using StudentDBWebApi.Repository;
using System.Text;
using System.Security.Claims;

namespace StudentDBWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Host.UseNLog();

            // Add services to the container.

            builder.Services.AddDbContext<UniversityContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("UniversityDB"))
            );

            // Identity Configuration
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
             
            })
            .AddEntityFrameworkStores<UniversityContext>()
            .AddDefaultTokenProviders();

            // JWT Authentication Configuration
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    ValidIssuer = "http://localhost:5187/",
                    ValidAudience = "http://localhost:5187/",
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes("e5c198cb3cd25f28a9da4f241a71433e3f726f67bc26f9cd543b41c1d9979a95"))
                };

                options.Events = new JwtBearerEvents
                {
                    OnTokenValidated = async context =>
                    {
                        var userManager = context.HttpContext.RequestServices.GetRequiredService<UserManager<ApplicationUser>>();
                        var user = await userManager.GetUserAsync(context.Principal);
                        var tokenStamp = context.Principal.FindFirstValue("SecurityStamp");

                        if (user == null || user.SecurityStamp != tokenStamp)
                        {
                            context.Fail("Token is invalid");
                        }
                    }
                };
            });

            builder.Services.AddScoped<IGenericRepository<Student>, GenericRepository<Student>>();
            builder.Services.AddScoped<IGenericRepository<Department>, GenericRepository<Department>>();

            builder.Services.AddControllers(op =>
            {
                op.Filters.Add<HandleExceptionFilterAttribute>();
                op.Filters.Add<MyResultFilter>();
            });
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            builder.Services.AddSwaggerGen();

            // CORS: allow frontend to access API endpoints
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });

            var app = builder.Build();


            //app.UseMiddleware<LoggingMiddleware>();
            app.UseLogging();
            app.UseException();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("AllowAll");

            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}

