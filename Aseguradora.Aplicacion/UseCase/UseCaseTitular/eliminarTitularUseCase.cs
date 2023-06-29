using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.UseCase;

public class eliminarTitularUseCase
{
    private readonly IRepositorioTitular _repo;
    public eliminarTitularUseCase(IRepositorioTitular repo){
        this._repo = repo;
    }
    public void Ejecutar(int id)
    {
        _repo.eliminarTitular(id);
    }
}