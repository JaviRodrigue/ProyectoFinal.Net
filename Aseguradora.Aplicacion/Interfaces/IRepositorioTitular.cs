using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.Interfaces;

public interface IRepositorioTitular
{
    void agregarTitular(Titular t);
    void modificarTitular(Titular t);
    void eliminarTitular(int id);
    List<Titular> listarTitular();
    List<Vehiculo> listarTitularesConVehiculos(int id);
}