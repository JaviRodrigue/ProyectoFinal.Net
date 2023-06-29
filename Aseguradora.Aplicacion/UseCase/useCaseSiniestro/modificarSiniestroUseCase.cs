using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.UseCase;

public class modificarSiniestroUseCase
{
    private readonly IRepositorioSiniestro _repo;
    public modificarSiniestroUseCase(IRepositorioSiniestro repo){
        this._repo = repo;
    }
    public void Ejecutar(Siniestro s)
    {
        _repo.modificarSiniestro(s);
    }
}