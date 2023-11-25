#region Register DI dependencies

using Bestellsystem_API.Data;
using Microsoft.EntityFrameworkCore;
using Bestellsystem_API.Data;
using Bestellsystem_API.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddControllers();
builder.Services.AddDbContext<BestellsystemContext>(opt =>
     opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddTransient<DbInitializer>();

// Needed for API access through the JS client; see UseCors()
builder.Services.AddCors(options =>
{
    options.AddPolicy("CORS_CONFIG", cors =>
    {
        cors.WithMethods("*")
            .WithHeaders("*")
            .WithOrigins("*");
    });
});



#endregion


#region Application Startup

var app = builder.Build();

// Add for cshtml page mappings
app.MapRazorPages();
app.MapControllers();
app.UseStaticFiles();

app.UseCors("CORS_CONFIG");

using (var scope = app.Services.CreateScope())
{
    // Execute db initializer
    scope.ServiceProvider.GetRequiredService<DbInitializer>().Run();
}

// startup server
app.Run();

#endregion