using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Daniel_Montero_Ap1_pFinal.Data;
using Daniel_Montero_Ap1_pFinal.BLL;
using Daniel_Montero_Ap1_pFinal.DAL;
using Blazored.Toast;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddBlazoredToast();


builder.Services.AddDbContext<Contexto>(options =>

                options.UseSqlite(builder.Configuration.GetConnectionString("ConStr"))

                );
builder.Services.AddTransient<AsistenciaBLL>();
builder.Services.AddTransient<CursoBLL>();
builder.Services.AddTransient<AulasBLL>();
builder.Services.AddTransient<TodoBLLModelCreating>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
