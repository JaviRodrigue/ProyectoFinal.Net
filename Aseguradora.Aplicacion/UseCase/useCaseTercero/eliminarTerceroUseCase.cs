using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.UseCase;

public class eliminarTerceroUseCase
{
    private readonly IRepositorioTercero _repo;
    public eliminarTerceroUseCase(IRepositorioTercero repo){
        this._repo = repo;
    }
    public void Ejecutar(int id)
    {
        _repo.eliminarTercero(id);
    }
}