using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.Interfaces;
public interface IRepositorioTercero
{
    void agregarTercero(Tercero t);
    void eliminarTercero(int id);
    void modificarTercero(Tercero t);
    List<Tercero> listarTercero();
}