using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.UseCase;

public class modificarVehiculoUseCase
{
    private readonly IRepositorioVehiculo _repo;
    public modificarVehiculoUseCase(IRepositorioVehiculo repoVehiculo){
        this._repo = repoVehiculo;
    }
    public void Ejecutar(Vehiculo v)
    {
        _repo.modificarVehiculo(v);
    }
}