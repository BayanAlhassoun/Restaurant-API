
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Restaurant.Core.Common;
using Restaurant.Core.Repositories;
using Restaurant.Core.Services;
using Restaurant.Infra.Common;
using Restaurant.Infra.Repositories;
using Restaurant.Infra.Services;
using System.Data.Common;
using System.Text;

namespace Restaurant.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,

                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Hello EveryOne, I hope you are all doing well, Hello EveryOne, I hope you are all doing well")),
                ClockSkew = TimeSpan.Zero
            });

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IDBContext, DBConetext>();
            builder.Services.AddScoped<ICategory_Repository, Category_Repository>();
            builder.Services.AddScoped<ICustomer_Repository, Customer_Repository>();
            builder.Services.AddScoped<ICustomer_Service, Customer_Service>();
            builder.Services.AddScoped<ICategory_Service, Category_Service>();
            builder.Services.AddScoped<IEmployee_Repository, EmployeeRepository>();
            builder.Services.AddScoped<IEmployee_Service, Employee_Service>();
            builder.Services.AddScoped<IOrder_Repository, Order_Repository>();
            builder.Services.AddScoped<IOrder_Service, Order_Service>();
            builder.Services.AddScoped<ILogin_Repository, Login_Repository>();
            builder.Services.AddScoped<ILogin_Service, Login_Service>();
            var app = builder.Build();

            

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
