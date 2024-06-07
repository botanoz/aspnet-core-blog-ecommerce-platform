using DataLayer.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataLayer.Entity { 

/// <summary>
/// ApplicationDbContext class representing the Entity Framework Core database context.
/// </summary>
public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    // DbSet properties representing the tables in the database
    public DbSet<About> Abouts { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartDetail> CartDetails { get; set; }
    public DbSet<ClientSay> ClientSays { get; set; }
    public DbSet<News> News { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Partner> Partners { get; set; }
    public DbSet<Portfolio> Portfolios { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Setting> Settings { get; set; }

    /// <summary>
    /// Configures the relationships and seed data for the entities.
    /// </summary>
    /// <param name="modelBuilder">The ModelBuilder instance used to configure the model.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed data for roles
        modelBuilder.Entity<ApplicationRole>().HasData(
            new ApplicationRole { Id = "role1", Name = "User", NormalizedName = "USER" },
            new ApplicationRole { Id = "role2", Name = "Admin", NormalizedName = "ADMIN" }
        );

        // Seed data for ApplicationUser
        var hasher = new PasswordHasher<ApplicationUser>();
        modelBuilder.Entity<ApplicationUser>().HasData(
            new ApplicationUser
            {
                Id = "admin1",
                ProfilePicture = "~/dist/img/user2-160x160.jpg",
                UserName = "admin@example.com",
                NormalizedUserName = "ADMIN@EXAMPLE.COM",
                Email = "admin@example.com",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Password1"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FirstName = "Admin",
                LastName = "User"
            },
            new ApplicationUser
            {
                Id = "user1",
                ProfilePicture = "~/dist/img/user2-160x160.jpg",
                UserName = "user1@example.com",
                NormalizedUserName = "USER1@EXAMPLE.COM",
                Email = "user1@example.com",
                NormalizedEmail = "USER1@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Password1"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FirstName = "John",
                LastName = "Doe"
            },
            new ApplicationUser
            {
                Id = "user2",
                ProfilePicture = "~/dist/img/user2-160x160.jpg",
                UserName = "user2@example.com",
                NormalizedUserName = "USER2@EXAMPLE.COM",
                Email = "user2@example.com",
                NormalizedEmail = "USER2@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Password1"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FirstName = "Jane",
                LastName = "Smith"
            },
            new ApplicationUser
            {
                Id = "user3",
                ProfilePicture = "~/dist/img/user2-160x160.jpg",
                UserName = "user3@example.com",
                NormalizedUserName = "USER3@EXAMPLE.COM",
                Email = "user3@example.com",
                NormalizedEmail = "USER3@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Password1"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FirstName = "Alice",
                LastName = "Johnson"
            },
            new ApplicationUser
            {
                Id = "user4",
                ProfilePicture = "~/dist/img/user2-160x160.jpg",
                UserName = "user4@example.com",
                NormalizedUserName = "USER4@EXAMPLE.COM",
                Email = "user4@example.com",
                NormalizedEmail = "USER4@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Password1"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FirstName = "Bob",
                LastName = "Brown"
            }
        );

        // Seed data for IdentityUserRole
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                UserId = "admin1",
                RoleId = "role2"
            },
            new IdentityUserRole<string>
            {
                UserId = "user1",
                RoleId = "role1"
            },
            new IdentityUserRole<string>
            {
                UserId = "user2",
                RoleId = "role1"
            },
            new IdentityUserRole<string>
            {
                UserId = "user3",
                RoleId = "role1"
            },
            new IdentityUserRole<string>
            {
                UserId = "user4",
                RoleId = "role1"
            }
        );

        // Seed data for Blog entity
        modelBuilder.Entity<Blog>().HasData(
            new Blog
            {
                Id = 1,
                CreatedDate = new DateTime(2024, 5, 30, 11, 7, 55, DateTimeKind.Utc),
                Description = "Description for Blog 1",
                IsActive = true,
                Date = new DateTime(2020, 1, 29),
                ThumbnailPath = "~/images/Bloggrid/Bloggrid_2@2x.jpg",
                Title = "Why you must experience design at least once",
                UserId = "admin1"
            },
            new Blog
            {
                Id = 2,
                CreatedDate = new DateTime(2024, 5, 30, 11, 7, 55, DateTimeKind.Utc),
                Description = "Description for Blog 2",
                IsActive = true,
                Date = new DateTime(2020, 1, 29),
                ThumbnailPath = "~/images/Bloggrid/Bloggrid_8@2x.jpg",
                Title = "Why you must experience design at least once",
                UserId = "admin1"
            },
            new Blog
            {
                Id = 3,
                CreatedDate = new DateTime(2024, 5, 30, 11, 7, 55, DateTimeKind.Utc),
                Description = "Description for Blog 3",
                IsActive = true,
                Date = new DateTime(2020, 1, 29),
                ThumbnailPath = "~/images/Bloggrid/Bloggrid_7@2x.jpg",
                Title = "Why you must experience design at least once",
                UserId = "admin1"
            },
            new Blog
            {
                Id = 4,
                CreatedDate = new DateTime(2024, 5, 30, 11, 7, 55, DateTimeKind.Utc),
                Description = "Description for Blog 4",
                IsActive = true,
                Date = new DateTime(2020, 1, 29),
                ThumbnailPath = "~/images/Bloggrid/Bloggrid_6@2x.jpg",
                Title = "Why you must experience design at least once",
                UserId = "admin1"
            },
            new Blog
            {
                Id = 5,
                CreatedDate = new DateTime(2024, 5, 30, 11, 7, 55, DateTimeKind.Utc),
                Description = "Description for Blog 5",
                IsActive = true,
                Date = new DateTime(2020, 1, 29),
                ThumbnailPath = "~/images/Bloggrid/Bloggrid_5@2x.jpg",
                Title = "Why you must experience design at least once",
                UserId = "admin1"
            },
            new Blog
            {
                Id = 6,
                CreatedDate = new DateTime(2024, 5, 30, 11, 7, 55, DateTimeKind.Utc),
                Description = "Description for Blog 6",
                IsActive = true,
                Date = new DateTime(2020, 1, 29),
                ThumbnailPath = "~/images/Bloggrid/Bloggrid_4@2x.jpg",
                Title = "Why you must experience design at least once",
                UserId = "admin1"
            },
            new Blog
            {
                Id = 7,
                CreatedDate = new DateTime(2024, 5, 30, 11, 7, 55, DateTimeKind.Utc),
                Description = "Description for Blog 7",
                IsActive = true,
                Date = new DateTime(2020, 1, 29),
                ThumbnailPath = "~/images/Bloggrid/Bloggrid_3@2x.jpg",
                Title = "Why you must experience design at least once",
                UserId = "admin1"
            },
            new Blog
            {
                Id = 8,
                CreatedDate = new DateTime(2024, 5, 30, 11, 7, 55, DateTimeKind.Utc),
                Description = "Description for Blog 8",
                IsActive = true,
                Date = new DateTime(2020, 1, 29),
                ThumbnailPath = "~/images/Bloggrid/Bloggrid_2@2x.jpg",
                Title = "Why you must experience design at least once",
                UserId = "admin1"
            },
            new Blog
            {
                Id = 9,
                CreatedDate = new DateTime(2024, 5, 30, 11, 7, 55, DateTimeKind.Utc),
                Description = "Description for Blog 9",
                IsActive = true,
                Date = new DateTime(2020, 1, 29),
                ThumbnailPath = "~/images/Bloggrid/Bloggrid_1@2x.jpg",
                Title = "Why you must experience design at least once",
                UserId = "admin1"
            }
        );

        // Seed data for Portfolio entity
        modelBuilder.Entity<Portfolio>().HasData(
            new Portfolio
            {
                Id = 1,
                CreatedDate = new DateTime(2024, 5, 30, 11, 7, 55, DateTimeKind.Utc),
                Description = "A branding project with a simple design approach.",
                IsActive = true,
                Title = "Simple Design",
                Client = "Branding Client",
                ProjectUrl = "~/images/Standard_list_blog/Standard_9@2x.jpg",
                UserId = "admin1"
            },
            new Portfolio
            {
                Id = 2,
                CreatedDate = new DateTime(2024, 5, 30, 11, 7, 55, DateTimeKind.Utc),
                Description = "A branding project with a simple design approach.",
                IsActive = true,
                Title = "Simple Design",
                Client = "Branding Client",
                ProjectUrl = "~/images/Standard_list_blog/Standard_8@2x.jpg",
                UserId = "admin1"
            },
            new Portfolio
            {
                Id = 3,
                CreatedDate = new DateTime(2024, 5, 30, 11, 7, 55, DateTimeKind.Utc),
                Description = "A branding project with a simple design approach.",
                IsActive = true,
                Title = "Simple Design",
                Client = "Branding Client",
                ProjectUrl = "~/images/Standard_list_blog/Standard_7@2x.jpg",
                UserId = "admin1"
            },
            new Portfolio
            {
                Id = 4,
                CreatedDate = new DateTime(2024, 5, 30, 11, 7, 55, DateTimeKind.Utc),
                Description = "A branding project with a simple design approach.",
                IsActive = true,
                Title = "Simple Design",
                Client = "Branding Client",
                ProjectUrl = "~/images/Standard_list_blog/Standard_6@2x.jpg",
                UserId = "admin1"
            },
            new Portfolio
            {
                Id = 5,
                CreatedDate = new DateTime(2024, 5, 30, 11, 7, 55, DateTimeKind.Utc),
                Description = "A branding project with a simple design approach.",
                IsActive = true,
                Title = "Simple Design",
                Client = "Branding Client",
                ProjectUrl = "~/images/Standard_list_blog/Standard_5@2x.jpg",
                UserId = "admin1"
            },
            new Portfolio
            {
                Id = 6,
                CreatedDate = new DateTime(2024, 5, 30, 11, 7, 55, DateTimeKind.Utc),
                Description = "A branding project with a simple design approach.",
                IsActive = true,
                Title = "Simple Design",
                Client = "Branding Client",
                ProjectUrl = "~/images/Standard_list_blog/Standard_4@2x.jpg",
                UserId = "admin1"
            },
            new Portfolio
            {
                Id = 7,
                CreatedDate = new DateTime(2024, 5, 30, 11, 7, 55, DateTimeKind.Utc),
                Description = "A branding project with a simple design approach.",
                IsActive = true,
                Title = "Simple Design",
                Client = "Branding Client",
                ProjectUrl = "~/images/Standard_list_blog/Standard_3@2x.jpg",
                UserId = "admin1"
            },
            new Portfolio
            {
                Id = 8,
                CreatedDate = new DateTime(2024, 5, 30, 11, 7, 55, DateTimeKind.Utc),
                Description = "A branding project with a simple design approach.",
                IsActive = true,
                Title = "Simple Design",
                Client = "Branding Client",
                ProjectUrl = "~/images/Standard_list_blog/Standard_2@2x.jpg",
                UserId = "admin1"
            },
            new Portfolio
            {
                Id = 9,
                CreatedDate = new DateTime(2024, 5, 30, 11, 7, 55, DateTimeKind.Utc),
                Description = "A branding project with a simple design approach.",
                IsActive = true,
                Title = "Simple Design",
                Client = "Branding Client",
                ProjectUrl = "~/images/Standard_list_blog/Standard_1@2x.jpg",
                UserId = "admin1"
            }
        );

        // Relationships and configurations

        // Blog relationships
        modelBuilder.Entity<Blog>()
            .HasOne(b => b.User)
            .WithMany(u => u.Blogs)
            .HasForeignKey(b => b.UserId);

        // Cart relationships
        modelBuilder.Entity<Cart>()
            .HasOne(c => c.User)
            .WithMany(u => u.Carts)
            .HasForeignKey(c => c.UserId);

        // CartDetail relationships
        modelBuilder.Entity<CartDetail>()
            .HasOne(cd => cd.Cart)
            .WithMany(c => c.CartDetails)
            .HasForeignKey(cd => cd.CartId);

        modelBuilder.Entity<CartDetail>()
            .HasOne(cd => cd.Product)
            .WithMany(p => p.CartDetails)
            .HasForeignKey(cd => cd.ProductId);

            // ClientSay relationships
            // (No foreign keys needed)

            // News relationships
            // (No foreign keys needed)

            // Order entity configuration
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.UserId)
                      .IsRequired();

                entity.Property(e => e.OrderDate)
                      .IsRequired();

                entity.Property(e => e.TotalAmount)
                      .IsRequired();

                entity.Property(e => e.Status)
                      .HasDefaultValue(OrderStatus.Pending)
                      .IsRequired();

                // Order relationships
                entity.HasOne(o => o.User)
                      .WithMany(u => u.Orders)
                      .HasForeignKey(o => o.UserId);
            });

            // OrderDetail relationships
            modelBuilder.Entity<OrderDetail>()
            .HasOne(od => od.Order)
            .WithMany(o => o.OrderDetails)
            .HasForeignKey(od => od.OrderId);

        modelBuilder.Entity<OrderDetail>()
            .HasOne(od => od.Product)
            .WithMany(p => p.OrderDetails)
            .HasForeignKey(od => od.ProductId);

        // Partner relationships
        // (No foreign keys needed)

        // Portfolio relationships
        modelBuilder.Entity<Portfolio>()
            .HasOne(p => p.User)
            .WithMany(u => u.Portfolios)
            .HasForeignKey(p => p.UserId);

            // Product relationships
            // (Configured through OrderDetail and CartDetail)
            //Seed data for Product entity
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id=1,
                        Name = "Flying Ninja",
                        Description = "A high-quality flying ninja toy.",
                        Price = 15.00m,
                        ImageUrl = "~/images/Shop/shop@2x.jpg",
                        CreatedDate = DateTime.UtcNow,
                        IsActive = true,
                        UpdatedDate = null,
                        DeletedDate = null
                    },
                     new Product
                     {
                         Id = 2,
                         Name = "Invisible Ninja",
                         Description = "An invisible ninja toy with stealth mode.",
                         Price = 20.00m,
                         ImageUrl = "~/images/Shop/shop@2x.jpg",
                         CreatedDate = DateTime.UtcNow,
                         IsActive = true,
                         UpdatedDate = null,
                         DeletedDate = null
                     },
                     new Product
                     {
                         Id = 3,
                         Name = "Speed Ninja",
                         Description = "A fast ninja toy with lightning speed.",
                         Price = 18.00m,
                         ImageUrl = "~/images/Shop/shop@2x.jpg",
                         CreatedDate = DateTime.UtcNow,
                         IsActive = true,
                         UpdatedDate = null,
                         DeletedDate = null
                     },
                     new Product
                     {
                         Id = 4,
                         Name = "Stealth Ninja",
                         Description = "A stealthy ninja toy with night vision.",
                         Price = 22.00m,
                         ImageUrl = "~/images/Shop/shop@2x.jpg",
                         CreatedDate = DateTime.UtcNow,
                         IsActive = true,
                         UpdatedDate = null,
                         DeletedDate = null
                     },
                     new Product
                     {
                         Id = 5,
                         Name = "Shadow Ninja",
                         Description = "A shadow ninja toy that blends into the dark.",
                         Price = 19.00m,
                         ImageUrl = "~/images/Shop/shop@2x.jpg",
                         CreatedDate = DateTime.UtcNow,
                         IsActive = true,
                         UpdatedDate = null,
                         DeletedDate = null
                     },
                     new Product
                     {
                         Id = 6,
                         Name = "Samurai Ninja",
                         Description = "A samurai ninja toy with a katana.",
                         Price = 25.00m,
                         ImageUrl = "~/images/Shop/shop@2x.jpg",
                         CreatedDate = DateTime.UtcNow,
                         IsActive = true,
                         UpdatedDate = null,
                         DeletedDate = null
                     },
                     new Product
                     {
                         Id = 7,
                         Name = "Rogue Ninja",
                         Description = "A rogue ninja toy with dual blades.",
                         Price = 23.00m,
                         ImageUrl = "~/images/Shop/shop@2x.jpg",
                         CreatedDate = DateTime.UtcNow,
                         IsActive = true,
                         UpdatedDate = null,
                         DeletedDate = null
                     },
                     new Product
                     {
                         Id = 8,
                         Name = "Mystic Ninja",
                         Description = "A mystic ninja toy with magical powers.",
                         Price = 28.00m,
                         ImageUrl = "~/images/Shop/shop@2x.jpg",
                         CreatedDate = DateTime.UtcNow,
                         IsActive = true,
                         UpdatedDate = null,
                         DeletedDate = null
                     },
                     new Product
                     {
                         Id = 9,
                         Name = "Warrior Ninja",
                         Description = "A warrior ninja toy with armor.",
                         Price = 30.00m,
                         ImageUrl = "~/images/Shop/shop@2x.jpg",
                         CreatedDate = DateTime.UtcNow,
                         IsActive = true,
                         UpdatedDate = null,
                         DeletedDate = null
                     }
                );

            // Setting relationships
            // (No foreign keys needed)

            //Seed data for About Entitity
            modelBuilder.Entity<About>().HasData(
                new About
                {
                    Id=1,
                    Name="Header",
                    Description= "A design and development agency based in London. We create digital products that make people’s lives easier.",
                },
                 new About
                 {
                     Id = 2,
                     Name = "Img",
                     Description = "~/images/About/about@2x.jpg",
                 },
                 new About
                 {
                     Id = 3,
                     Name = "Story",
                     Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam,",
                 },
                 new About
                 {
                     Id = 4,
                     Name = "Mission",
                     Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam,",
                 },
                 new About
                 {
                     Id = 5,
                     Name = "Value",
                     Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam,",
                 }

                );
        }
}
}