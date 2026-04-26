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

// ===== Build App ===== //
var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();