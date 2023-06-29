using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.UseCase;

public class listarTitularUseCase
{
    private readonly IRepositorioTitular _repo;
    public listarTitularUseCase(IRepositorioTitular repo){
        this._repo = repo;
    }
    public List<Titular> Ejecutar()
    {
        return this._repo.listarTitular();
    }
}