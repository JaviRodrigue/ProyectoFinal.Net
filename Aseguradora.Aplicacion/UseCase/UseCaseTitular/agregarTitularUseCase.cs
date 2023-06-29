using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.UseCase;

public class agregarTitularUseCase
{
    private readonly IRepositorioTitular _repo;
    public agregarTitularUseCase(IRepositorioTitular repo){
        this._repo = repo;
    }
    public void Ejecutar(Titular t)
    {
        _repo.agregarTitular(t);
    }
}