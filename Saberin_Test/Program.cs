using Saberin_Test.Data.Context;
using Saberin_Test.Data.Repository;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add service for the new repo
builder.Services.AddSingleton<IApiRepository, ApiRepository>();
builder.Services.AddDbContext<ApiContext>();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
//	app.UseSwagger();
//	app.UseSwaggerUI();
	app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

