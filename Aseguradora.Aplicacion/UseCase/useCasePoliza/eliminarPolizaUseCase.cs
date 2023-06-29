using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.UseCase;

public class eliminarPolizaUseCase
{
    private readonly IRepositorioPoliza _repo;
    public eliminarPolizaUseCase(IRepositorioPoliza repo){
        this._repo = repo;
    }
    public void Ejecutar(int id)
    {
        _repo.eliminarPoliza(id);
    }
}