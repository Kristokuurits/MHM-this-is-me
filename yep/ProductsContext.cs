using Microsoft.EntityFrameworkCore;

namespace GetStartedWinForms;

public class ProductsContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=products.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Mahl" },
            new Category { CategoryId = 2, Name = "Energia joogid" },
            new Category { CategoryId = 3, Name = "Limonaad" },
            new Category { CategoryId = 4, Name = "Alkohool" });

        modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = 1, CategoryId = 1, Name = "Apelsinimahl" },
            new Product { ProductId = 2, CategoryId = 1, Name = "Õunamahl" },
            new Product { ProductId = 3, CategoryId = 1, Name = "Multimahl" },
            new Product { ProductId = 4, CategoryId = 1, Name = "Tomatimahl" },
            new Product { ProductId = 5, CategoryId = 1, Name = "Ploominektar" },
            new Product { ProductId = 6, CategoryId = 1, Name = "Jõhvikajook" },
            new Product { ProductId = 7, CategoryId = 1, Name = "Viinamarja mahl" },
            new Product { ProductId = 8, CategoryId = 1, Name = "Multipuuvilja mahl" },
            new Product { ProductId = 9, CategoryId = 1, Name = "Ananassinektar" },
            new Product { ProductId = 10, CategoryId = 2, Name = "Red Bull" },
            new Product { ProductId = 11, CategoryId = 2, Name = "Starter" },
            new Product { ProductId = 12, CategoryId = 2, Name = "Monster" },
            new Product { ProductId = 13, CategoryId = 2, Name = "Burn" },
            new Product { ProductId = 14, CategoryId = 2, Name = "Battery" },
            new Product { ProductId = 15, CategoryId = 2, Name = "Dynamit" },
            new Product { ProductId = 16, CategoryId = 3, Name = "Fanta" },
            new Product { ProductId = 17, CategoryId = 3, Name = "Sprite" },
            new Product { ProductId = 18, CategoryId = 3, Name = "Coca-Cola" },
            new Product { ProductId = 19, CategoryId = 3, Name = "Kelluke" },
            new Product { ProductId = 20, CategoryId = 3, Name = "Valge klaar" },
            new Product { ProductId = 21, CategoryId = 4, Name = "Õlu" },
            new Product { ProductId = 22, CategoryId = 4, Name = "Vein" },
            new Product { ProductId = 23, CategoryId = 4, Name = "Viin" },
            new Product { ProductId = 24, CategoryId = 4, Name = "Siider" },
            new Product { ProductId = 25, CategoryId = 4, Name = "Šampanjad" },
            new Product { ProductId = 26, CategoryId = 4, Name = "Jägermeister" });
    }
}