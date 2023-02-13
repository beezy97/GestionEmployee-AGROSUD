using GestionEmployee.Data;
using GestionEmployee.Services.EmployeeService;
using GestionEmployee.Services.RoleService;
using GestionEmployee.Services.ServiceService;
using GestionEmployee.Services.SiteService;
using GestionEmployee.Services.UserService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ISiteService, SiteService>();
builder.Services.AddScoped<IServiceService, ServiceService>();
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultsConnection"));
});

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

app.UseCors(builder => builder
     .AllowAnyOrigin()
     .AllowAnyMethod()
     .AllowAnyHeader());

app.Run();
