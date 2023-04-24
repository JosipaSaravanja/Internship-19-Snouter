using Microsoft.EntityFrameworkCore;
using Data.Entities;
namespace Data;

public class SnouterContext : DbContext
{
    public SnouterContext(DbContextOptions<SnouterContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; } 
    public DbSet<SubCategory> SubCategories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Location> Locations { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=snouter;Username=postgres;Password=postgres;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .HasMany(c => c.SubCategories)
            .WithOne(sc => sc.Category)
            .HasForeignKey(sc => sc.CategoryId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<Category>()
            .HasMany(c => c.Products)
            .WithOne(p => p.Category)
            .HasForeignKey(p => p.CategoryId)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Location>()
            .Property(l => l.Longitude)
            .HasColumnType("double precision");
        modelBuilder.Entity<Location>()
            .Property(l => l.Latitude)
            .HasColumnType("double precision");
        modelBuilder.Entity<SubCategory>()
            .HasMany(sc => sc.Products)
            .WithOne(p => p.SubCategory)
            .HasForeignKey(p => p.SubCategoryId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<User>()
            .HasMany(u => u.Products)
            .WithOne(p => p.Seller)
            .HasForeignKey(p => p.SellerId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<User>()
            .HasMany(u => u.Purchases)
            .WithOne(p => p.Buyer)
            .HasForeignKey(p => p.BuyerId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<Location>()
            .HasMany(l => l.Products)
            .WithOne(p => p.Location)
            .HasForeignKey(p => p.LocationId)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Product>()
            .Property(p => p.Data)
            .HasConversion(
                v => v.ToString(),
                v => Newtonsoft.Json.JsonConvert.DeserializeObject<Newtonsoft.Json.Linq.JObject>(v)); 
        modelBuilder.Entity<SubCategory>()
            .Property(p => p.Schema)
            .HasConversion(
                v => v.ToString(),
                v => Newtonsoft.Json.JsonConvert.DeserializeObject<Newtonsoft.Json.Schema.JSchema>(v));
        
        Seeder.Seed(modelBuilder);
    }
    

}