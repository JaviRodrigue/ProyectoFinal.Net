using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.UseCase;

public class agregarSiniestroUseCase
{
    private readonly IRepositorioSiniestro _repo;

    public agregarSiniestroUseCase(IRepositorioSiniestro repoSiniestro){
        this._repo = repoSiniestro;
    }
    public void Ejecutar(Siniestro s)
    {
        this._repo.agregarSiniestro(s);
    }
}