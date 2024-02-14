using HospitalManager.Business.Abstract;
using HospitalManager.Business.Concrete;
using HospitalManager.DataAccess.Abstract;
using HospitalManager.DataAccess.Concrete;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    var filename = Assembly.GetExecutingAssembly().GetName().Name + ".xml";
    var filepatch =Path.Combine(AppContext.BaseDirectory, filename);
    options.IncludeXmlComments(filepatch);
});
builder.Services.AddScoped<IEmployeeService,EmployeeManager>();
builder.Services.AddScoped<ICustomerService,CustomerManager>();
builder.Services.AddScoped<IShipperService,ShipperManager>();
builder.Services.AddScoped<IEmployeeRepository,EmployeeRepository>();
builder.Services.AddScoped<ICustomerRepository,CustomerRepository>();
builder.Services.AddScoped<IShipperRepository,ShipperRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
