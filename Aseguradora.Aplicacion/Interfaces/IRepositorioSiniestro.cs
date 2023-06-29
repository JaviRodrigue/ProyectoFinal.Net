using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.Interfaces;
public interface IRepositorioSiniestro
{
    void agregarSiniestro(Siniestro s);
    void modificarSiniestro(Siniestro s);
    void eliminarSiniestro(int id);
    List<Siniestro> listarSiniestro();
}