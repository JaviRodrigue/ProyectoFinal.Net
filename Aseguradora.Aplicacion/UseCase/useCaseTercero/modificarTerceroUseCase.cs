using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.UseCase;

public class modificarTerceroUseCase
{
    private readonly IRepositorioTercero _repo;
    public modificarTerceroUseCase(IRepositorioTercero repoTercero){
        this._repo = repoTercero;
    }
    public void Ejecutar(Tercero t)
    {
        _repo.modificarTercero(t);
    }
}