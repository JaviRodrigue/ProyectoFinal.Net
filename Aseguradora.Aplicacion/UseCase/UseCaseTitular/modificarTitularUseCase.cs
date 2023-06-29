using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.UseCase;

public class modificarTitularUseCase
{
    private readonly IRepositorioTitular _repo;
    public modificarTitularUseCase(IRepositorioTitular repo){
        this._repo = repo;
    }
    public void Ejecutar(Titular t)
    {
        _repo.modificarTitular(t);
    }
}