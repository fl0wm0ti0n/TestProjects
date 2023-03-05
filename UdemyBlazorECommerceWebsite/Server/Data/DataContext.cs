using System.Security.Cryptography;

namespace UdemyBlazorECommerceWebsite.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Buch 1",
                    Description = "Spannend",
                    ImageUrl = "",
                    Price = 9.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "1984",
                    Description = "Nineteen Eighty-Four, deutscher Alternativtitel: Neunzehnhundertvierundachtzig), geschrieben von 1946 bis 1948[1] und erschienen im Juni 1949, ist ein dystopischer Roman von George Orwell (eigentlich Eric Arthur Blair), in dem ein totalitärer Überwachungsstaat im Jahr 1984 dargestellt wird. ",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/de/b/b5/1984_%28Frontcover_der_Erstausgabe_von_1949%29.jpg",
                    Price = 19.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. ",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 10.99m
                },
                new Product
                {
                    Id = 4,
                    Title = "Bibel",
                    Description = "Als Bibel (altgriechisch βιβλία biblia ‚Bücher‘) oder (Die) Heilige Schrift bezeichnet man die wichtigste religiöse Textsammlung im Judentum wie auch im Christentum.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b0/Gutenberg_Bible.jpg",
                    Price = 5.99m
                }
            );
        }

        public DbSet<Product> Products { get; set; }
    }
}
