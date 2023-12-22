using cnxdevsoft_backend_assignment.Components;
using cnxdevsoft_backend_assignment.Data;
using cnxdevsoft_backend_assignment.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Add Controllers
builder.Services.AddControllers();
builder.Services.AddHttpClient();

// Add Swagger API Document
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Math Operation API", Version = "v1" });
});

// Add Database Context
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(configuration.GetConnectionString("connSQLServer")));

// Add Scoped for Services
builder.Services.AddScoped<IMathService, MathService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else {
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    });
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

// Map Controllers
app.MapControllers();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
