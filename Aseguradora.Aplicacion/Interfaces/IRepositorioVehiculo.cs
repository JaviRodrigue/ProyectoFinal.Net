using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.Interfaces;

public interface IRepositorioVehiculo
{
    void agregarVehiculo(Vehiculo v);
    void modificarVehiculo(Vehiculo v);
    void eliminarVehiculo(int id);
    List<Vehiculo> listarVehiculo();
}