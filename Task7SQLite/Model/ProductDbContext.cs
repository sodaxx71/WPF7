using Microsoft.EntityFrameworkCore;

public class ProductDbContext : DbContext
{
    #region Конструктор
    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
    #endregion

    #region Public свойство
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(GetProducts());
        base.OnModelCreating(modelBuilder);
    }

    #endregion

    #region методы
    private Product[] GetProducts() => new Product[] {
        new Product{
    ProductID = 1,
    ProductName = "Масло моторное Motul 7100 10W-40 4T",
    ProductDescription = "Полусинтетическое моторное масло для 4-тактных мотоциклов с высокими эксплуатационными характеристиками.",
    ProductPrice = 1890,
    ProductUnit = 24
},

new Product{
    ProductID = 2,
    ProductName = "Цепь приводная DID 520VX2",
    ProductDescription = "Высококачественная роликовая цепь с золотистым покрытием, повышенной износостойкости.",
    ProductPrice = 5690,
    ProductUnit = 15
},

new Product{
    ProductID = 3,
    ProductName = "Шлем LS2 Stream Evo",
    ProductDescription = "Интегральный шлем с системой вентиляции, сертифицирован ECE 22.05. Вес 1450±50г.",
    ProductPrice = 8990,
    ProductUnit = 8
},

new Product{
    ProductID = 4,
    ProductName = "Перчатки мотозащитные Alpinestars SMX-1 Air",
    ProductDescription = "Летние перчатки с защитой костяшек и улучшенной вентиляцией. Кожа/текстиль.",
    ProductPrice = 4590,
    ProductUnit = 12
},

new Product{
    ProductID = 5,
    ProductName = "Аккумулятор Yuasa YTX12-BS",
    ProductDescription = "Свинцово-кислотный аккумулятор 12V 10Ah для большинства современных мотоциклов.",
    ProductPrice = 6290,
    ProductUnit = 6
},

new Product{
    ProductID = 6,
    ProductName = "Свеча зажигания NGK CR8E",
    ProductDescription = "Стандартная свеча зажигания с медным сердечником, резьба M10x1.0, длина 19мм.",
    ProductPrice = 490,
    ProductUnit = 42
},

new Product{
    ProductID = 7,
    ProductName = "Тормозные колодки EBC FA363",
    ProductDescription = "Органические тормозные колодки для переднего суппорта, обеспечивают плавное торможение.",
    ProductPrice = 2190,
    ProductUnit = 18
    }

    };
    #endregion
}