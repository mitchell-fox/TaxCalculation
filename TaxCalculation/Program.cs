using TaxCalculation.WebAPI.Settings;

var builder = WebApplication.CreateBuilder(args);

var taxJarApiConfigSection = builder.Configuration.GetSection(TaxJarApiOptions.TaxJarApi);
builder.Services.Configure<TaxJarApiOptions>(taxJarApiConfigSection);

builder.Services.AddControllers();
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
