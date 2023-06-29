using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.UseCase;

public class modificarPolizaUseCase
{
    private readonly IRepositorioPoliza _repo;
    public modificarPolizaUseCase(IRepositorioPoliza repoPoliza){
        this._repo = repoPoliza;
    }
    public void Ejecutar(Poliza p)
    {
        _repo.modificarPoliza(p);
    }
}