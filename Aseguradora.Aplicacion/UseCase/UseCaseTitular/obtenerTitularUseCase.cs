namespace Aseguradora.Aplicacion.UseCase;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
public class obtenerTitularUseCase
{
    private readonly IRepositorioTitular _repo;
    public obtenerTitularUseCase(IRepositorioTitular repo){
        this._repo = repo;
    }
    public Titular? Ejecutar(int id)
    {
        return _repo.obtenerTitular(id);
    }
}