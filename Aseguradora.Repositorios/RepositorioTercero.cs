namespace Aseguradora.Repositorio;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class RepositorioTercero : IRepositorioTercero
{
    public void agregarTercero(Tercero t)
    {
        using(var context = new AseguradoraContext()){
            bool validacion = context.Terceros.FirstOrDefault
            (v => v.dni == t.dni) != null;
            bool confirm = context.Siniestros.FirstOrDefault(z => z.Id == t.siniestroid) != null;
            if(!validacion)
            {
                if(confirm)
                {
                    context.Terceros.Add(t);
                    context.SaveChanges();
                }
                else{
                    throw new Exception("ErrorAgregarTercero1");
                }
            }
            else{
                throw new Exception($"ErrorAgregarTercero2");
            }
        }
    }

    public void eliminarTercero(int id)
    {
        using(var context = new AseguradoraContext())
        {
            var validacion = context.Terceros.FirstOrDefault(v => v.id == id);
            if(validacion != null)
            {
                
                context.Terceros.Remove(validacion);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("ErrorEliminar");
            }
        }
    }
    public void modificarTercero(Tercero t)
    {
        using( var context = new AseguradoraContext())
        {
            var aux = context.Terceros.FirstOrDefault(v => v.id == t.id);
            bool validacion = context.Siniestros.FirstOrDefault(x => x.Id == t.siniestroid) != null;
            if(aux != null)
            {
                if(validacion)
                {
                    aux.apellido = t.apellido;
                    aux.nombre = t.nombre;
                    aux.dni = t.dni;
                    aux.siniestroid = t.siniestroid;
                    aux.tel = t.tel;
                    aux.nombreAseguradora = t.nombreAseguradora;
                    context.SaveChanges();
                }
                else{
                    throw new Exception("ErrorModificar1");
                }
            }
            else{
                throw new Exception("ErrorModificar2");
            }
        }
    }

    public List<Tercero> listarTercero()
    {
        using(var context = new AseguradoraContext())
        {
            return context.Terceros.ToList();
        }
    }

}