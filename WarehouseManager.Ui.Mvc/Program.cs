using Microsoft.EntityFrameworkCore;
using WarehouseManager.Repository;
using WarehouseManager.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();



//Add InMemory Database
builder.Services.AddDbContext<WarehouseManagerDbContext>(options =>
{
    options.UseInMemoryDatabase(nameof(WarehouseManagerDbContext));
    //options.UseSqlServer(connectionString);
});

// Register Services
builder.Services.AddScoped<ArticleService>();
builder.Services.AddScoped<WarehouseService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{

    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    using var scope = app.Services.CreateScope();
    var dbContext = scope.ServiceProvider.GetRequiredService<WarehouseManagerDbContext>();
    //if (dbContext.Database.IsInMemory())
    //{
    dbContext.FillInMockData();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=StockManagement}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
