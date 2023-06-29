using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.UseCase;

public class eliminarVehiculoUseCase
{
    private readonly IRepositorioVehiculo _repo;
    public eliminarVehiculoUseCase(IRepositorioVehiculo repo){
        this._repo = repo;
    }
    public void Ejecutar(int id)
    {
        _repo.eliminarVehiculo(id);
    }
}