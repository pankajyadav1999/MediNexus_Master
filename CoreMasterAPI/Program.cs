using Microsoft.EntityFrameworkCore;
using CoreMasterAPI.Extensions;
using CoreBussiness.MappingProfiles;

var builder = WebApplication.CreateBuilder(args);

// ===== Controller ===== //
builder.Services.AddControllers();

// ===== AutoMapper ===== //
builder.Services.AddAutoMapper(typeof(MappingProfile));

// ===== RegisterService ===== //
builder.Services.RegisterServices(builder.Configuration);


// ===== CORS ===== //
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularApp", policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});
// ===== Build App ===== //
var app = builder.Build();

app.UseHttpsRedirection();

// ===== CORS ===== //
app.UseCors("AllowAngularApp");

app.UseAuthorization();

app.MapControllers();

app.Run();