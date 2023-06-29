using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.UseCase;

public class listarSiniestroUseCase
{
    private readonly IRepositorioSiniestro _repo;
    public listarSiniestroUseCase(IRepositorioSiniestro repo){
        this._repo = repo;
    }
    public List<Siniestro> Ejecutar()
    {
        return this._repo.listarSiniestro();
    }
}