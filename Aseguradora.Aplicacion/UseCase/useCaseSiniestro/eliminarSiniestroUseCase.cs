using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.UseCase;

public class eliminarSiniestroUseCase
{
    private readonly IRepositorioSiniestro _repo;
    public eliminarSiniestroUseCase(IRepositorioSiniestro repo){
        this._repo = repo;
    }
    public void Ejecutar(int id)
    {
        _repo.eliminarSiniestro(id);
    }
}