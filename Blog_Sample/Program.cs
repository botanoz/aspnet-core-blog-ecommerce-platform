using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DataLayer.Model;
using DataLayer.Repository.GenericRepository;
using DataLayer.Repository.SpecificRepository.Class;
using DataLayer.Repository.SpecificRepository.Interface;
using BusinessLayer.Services.GenericServices;
using BusinessLayer.Services.UnitOfWork;
using BusinessLayer.Services.SipecificServices.Class;
using BusinessLayer.Services.SipecificServices.Interface;
using DataLayer.Entity;
namespace Blog_Sample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Configure services and add them to the container

            // Add DbContext with EF Core
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Add Identity services and configure them
            builder.Services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // Configure Identity cookie settings
            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/Account/Login"; // Path to the login page
                options.LogoutPath = $"/Account/Logout"; // Path to the logout page
                options.AccessDeniedPath = $"/Account/AccessDenied"; // Path to the access denied page
            });

            // Register repositories and UnitOfWork
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            builder.Services.AddScoped<IAboutRepository, AboutRepository>();
            builder.Services.AddScoped<IBlogRepository, BlogRepository>();
            builder.Services.AddScoped<ICartRepository, CartRepository>();
            builder.Services.AddScoped<ICartDetailRepository, CartDetailRepository>();
            builder.Services.AddScoped<IClientSayRepository, ClientSayRepository>();
            builder.Services.AddScoped<INewsRepository, NewsRepository>();
            builder.Services.AddScoped<IOrderRepository, OrderRepository>();
            builder.Services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            builder.Services.AddScoped<IPartnerRepository, PartnerRepository>();
            builder.Services.AddScoped<IPortfolioRepository, PortfolioRepository>();
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<ISettingRepository, SettingRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();

            // Register services
            builder.Services.AddScoped<IAboutService, AboutService>();
            builder.Services.AddScoped<IBlogService, BlogService>();
            builder.Services.AddScoped<ICartService, CartService>();
            builder.Services.AddScoped<ICartDetailService, CartDetailService>();
            builder.Services.AddScoped<IClientSayService, ClientSayService>();
            builder.Services.AddScoped<INewsService, NewsService>();
            builder.Services.AddScoped<IOrderService, OrderService>();
            builder.Services.AddScoped<IOrderDetailService, OrderDetailService>();
            builder.Services.AddScoped<IPartnerService, PartnerService>();
            builder.Services.AddScoped<IPortfolioService, PortfolioService>();
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ISettingService, SettingService>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddSingleton<IWebHostEnvironment>(builder.Environment);

            // Add controllers with views
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
