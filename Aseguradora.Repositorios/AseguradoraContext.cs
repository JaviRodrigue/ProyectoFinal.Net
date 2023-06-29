using Microsoft.EntityFrameworkCore;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Repositorio;
public class AseguradoraContext : DbContext
{
    #nullable disable
    public DbSet<Titular> Titulares{get;set;}
    public DbSet<Poliza> Polizas{get; set;}
    public DbSet<Vehiculo> Vehiculos{get;set;}
    public DbSet<Siniestro> Siniestros{get;set;}
    public DbSet<Tercero> Terceros{get;set;}
    #nullable enable
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=Aseguradora.sqlite");
    }
}