using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.Interfaces;

public interface IRepositorioPoliza
{
    void agregarPoliza(Poliza p);
    void modificarPoliza(Poliza p);
    void eliminarPoliza(int id);
    List<Poliza> listarPoliza();

}