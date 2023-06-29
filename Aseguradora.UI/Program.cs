using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Aseguradora.UI.Data;

using Aseguradora.Repositorio;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.UseCase;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddTransient<agregarTitularUseCase>();
builder.Services.AddTransient<eliminarTitularUseCase>();
builder.Services.AddTransient<modificarTitularUseCase>();
builder.Services.AddTransient<listarTitularUseCase>();
builder.Services.AddTransient<listarTitularesConVehiculosUseCase>();

builder.Services.AddTransient<agregarVehiculoUseCase>();
builder.Services.AddTransient<eliminarVehiculoUseCase>();
builder.Services.AddTransient<modificarVehiculoUseCase>();
builder.Services.AddTransient<listarVehiculoUseCase>();

builder.Services.AddTransient<agregarPolizaUseCase>();
builder.Services.AddTransient<eliminarPolizaUseCase>();
builder.Services.AddTransient<modificarPolizaUseCase>();
builder.Services.AddTransient<listarPolizaUseCase>();

builder.Services.AddTransient<agregarTerceroUseCase>();
builder.Services.AddTransient<eliminarTerceroUseCase>();
builder.Services.AddTransient<modificarTerceroUseCase>();
builder.Services.AddTransient<listarTerceroUseCase>();

builder.Services.AddTransient<agregarSiniestroUseCase>();
builder.Services.AddTransient<eliminarSiniestroUseCase>();
builder.Services.AddTransient<modificarSiniestroUseCase>();
builder.Services.AddTransient<listarSiniestroUseCase>();

builder.Services.AddScoped<IRepositorioTitular, RepositorioTitular>();
builder.Services.AddScoped<IRepositorioVehiculo, RepositorioVehiculo>();
builder.Services.AddScoped<IRepositorioPoliza, RepositorioPoliza>();
builder.Services.AddScoped<IRepositorioSiniestro, RepositorioSiniestro>();
builder.Services.AddScoped<IRepositorioTercero, RepositorioTercero>();



CrearBaseDato.Crear();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) 
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
