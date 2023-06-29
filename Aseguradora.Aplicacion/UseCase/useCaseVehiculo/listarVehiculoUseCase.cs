using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.UseCase;

public class listarVehiculoUseCase
{
    private readonly IRepositorioVehiculo _repo;
    public listarVehiculoUseCase(IRepositorioVehiculo repo){
        this._repo = repo;
    }
    public List<Vehiculo> Ejecutar()
    {
        return this._repo.listarVehiculo();
    }
}