using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.UseCase;

public class listarPolizaUseCase
{
    private readonly IRepositorioPoliza _repo;
    public listarPolizaUseCase(IRepositorioPoliza repo){
        this._repo = repo;
    }
    public List<Poliza> Ejecutar()
    {
        return this._repo.listarPoliza();
    }
}