using EducationDepartment.API;
using EducationDepartment.API.Services;
using EducationDepartment.Domain;
using EducationDepartment.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen(options =>
{
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    options.IncludeXmlComments(xmlPath);
});

builder.Services.AddDbContext<EducationDepartmentContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString(nameof(EducationDepartment));
    var serverVersion = new MySqlServerVersion(new Version(8, 0, 39));
    options.UseMySql(connectionString, serverVersion);
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<DepartmentRepository>();
builder.Services.AddScoped<UniversityRepository>();
builder.Services.AddScoped<FacultyRepository>();
builder.Services.AddScoped<DepartmentSpecialtyRepository>();
builder.Services.AddScoped<SpecialtyRepository>();
builder.Services.AddScoped<QueryRepository>();

builder.Services.AddScoped<DepartmentService>();
builder.Services.AddScoped<UniversityService>();
builder.Services.AddScoped<FacultyService>();
builder.Services.AddScoped<DepartmentSpecialtyService>();
builder.Services.AddScoped<SpecialtyService>();
builder.Services.AddScoped<QueryService>();

builder.Services.AddScoped<Database>();

builder.Services.AddAutoMapper(typeof(Mapping));

var app = builder.Build();

app.UseCors("AllowAll");

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
