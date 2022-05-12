


namespace ResturantWebApi.Infrastructure
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductFluentApi());
            modelBuilder.ApplyConfiguration(new CategoryFluentApi());
        }



    }
}
