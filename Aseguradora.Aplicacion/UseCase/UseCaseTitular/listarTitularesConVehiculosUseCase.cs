namespace Aseguradora.Aplicacion.UseCase;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
public class listarTitularesConVehiculosUseCase
{
    private readonly IRepositorioTitular _repo;
    public listarTitularesConVehiculosUseCase(IRepositorioTitular repoTitular)
    {
        this._repo = repoTitular;
    }
    public List<Vehiculo> Ejecutar(int id)
    {
        return this._repo.listarTitularesConVehiculos(id);
    }
}