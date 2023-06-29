using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.UseCase;

public class agregarTerceroUseCase
{
    private readonly IRepositorioTercero _repo;
    public agregarTerceroUseCase(IRepositorioTercero repoTercero, IRepositorioSiniestro repoSiniestro){
        this._repo = repoTercero;
    }
    public void Ejecutar(Tercero t)
    {
        _repo.agregarTercero(t);
    }
}