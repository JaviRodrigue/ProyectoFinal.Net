using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.UseCase;

public class agregarPolizaUseCase
{
    private readonly IRepositorioPoliza _repo;
    public agregarPolizaUseCase(IRepositorioPoliza repoPoliza){
        this._repo = repoPoliza;
    }
    public void Ejecutar(Poliza p)
    {
        this._repo.agregarPoliza(p);
    }
}