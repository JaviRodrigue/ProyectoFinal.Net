using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.UseCase;

public class listarTerceroUseCase
{
    private readonly IRepositorioTercero _repo;
    public listarTerceroUseCase(IRepositorioTercero repo){
        this._repo = repo;
    }
    public List<Tercero> Ejecutar()
    {
        return this._repo.listarTercero();
    }
}