using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.UseCase;

public class agregarVehiculoUseCase
{
    private readonly IRepositorioVehiculo _repo;
    public agregarVehiculoUseCase(IRepositorioVehiculo repoVehiculo){
        this._repo = repoVehiculo;
    }
    public void Ejecutar(Vehiculo v)
    {
        _repo.agregarVehiculo(v);
    }
}