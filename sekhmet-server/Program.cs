using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using sekhmet_server;
using sekhmet_server.Models;

var builder = WebApplication.CreateBuilder(args);


ConfigServices();

ConfigCors();

RunApp();

void ConfigServices()
{
	builder.Services.AddControllers();
	builder.Services.AddEndpointsApiExplorer();
	builder.Services.AddSwaggerGen();
	builder.Services.AddRepositories();
	builder.Services.AddServices();
    builder.Services.AddDbContext<SekhmetContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SekhmetDb"))); 

}

void ConfigCors()
{
	builder.Services.AddCors(options =>
	{
		options.AddPolicy("AllowAll",
			 builder =>
			 {
				 builder.AllowAnyOrigin()
								  .AllowAnyMethod()
								  .AllowAnyHeader();
			 });
	});

}
void RunApp()
{
	var app = builder.Build();

	if (app.Environment.IsDevelopment())
	{
		app.UseSwagger();
		app.UseSwaggerUI();
	}

	app.UseHttpsRedirection();

	app.UseRouting();

	app.UseCors("AllowAll");

	app.UseAuthorization();

	app.MapControllers();

	app.Run();
}