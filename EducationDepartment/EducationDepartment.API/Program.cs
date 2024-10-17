using EducationDepartment.API;
using EducationDepartment.API.Services;
using EducationDepartment.Domain.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<DepartmentRepository>();
builder.Services.AddSingleton<UniversityRepository>();
builder.Services.AddSingleton<FacultyRepository>();
builder.Services.AddSingleton<DeparmentSpecialtyRepository>();
builder.Services.AddSingleton<SpecialtyRepository>();
builder.Services.AddSingleton<QueryRepository>();

builder.Services.AddSingleton<DepartmentService>();
builder.Services.AddSingleton<UniversityService>();
builder.Services.AddSingleton<FacultyService>();
builder.Services.AddSingleton<DepartmentSpecialtyService>();
builder.Services.AddSingleton<SpecialtyService>();
builder.Services.AddSingleton<QueryService>();

builder.Services.AddSingleton<Database>();

builder.Services.AddAutoMapper(typeof(Mapping));

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
