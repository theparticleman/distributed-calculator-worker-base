using DistributedCalculatorWorker.Web;
using DistributedCalculatorWorker.Web.Domain;
using TestableHttp;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<RegisterWorkflow>();
builder.Services.AddSingleton<IJsonSerializer, JsonSerializer>();
DependencyInjectionConfig.ConfigureServices(builder.Services);


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();
app.MapRazorPages();

app.Run();
