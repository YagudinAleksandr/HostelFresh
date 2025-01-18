using HostelFresh.Server;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.GetConfigurations(builder.Configuration);
builder.Services.GetDatabaseContext(builder.Configuration);
builder.Services.GetServices();
builder.Services.GetRepositories();
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
