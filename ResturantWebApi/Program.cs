

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//DbContext configuration
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection"),
    b =>b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))); //here i am going to specify where to find application dbcontext

//Repository Connection Configuration
//builder.Services.AddTransient (typeof(IBaseRepository<>),typeof(BaseRepositoryImp<>));
//builder.Services.AddTransient(typeof(IBaseServices<>), typeof(BaseServicesImp<>));
//builder.Services.AddTransient<IProductServices, ProductServicesImp>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWorkImp>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
