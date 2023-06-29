namespace Aseguradora.Repositorio;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
public class RepositorioVehiculo : IRepositorioVehiculo
{ 
    public void agregarVehiculo(Vehiculo vehiculo)
    {
        using(var context = new AseguradoraContext())
        {
            bool validacion = context.Vehiculos.FirstOrDefault(v => v.dominio == vehiculo.dominio) != null;
            bool valid = context.Titulares.FirstOrDefault(t => t.id == vehiculo.titularId) != null;
            if(!validacion){
                if(valid)
                {
                    context.Vehiculos.Add(vehiculo);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception ("1");
                }
            }
            else{
                throw new Exception("2");
            }
        }
    }
    public void eliminarVehiculo(int Id)
    {
        using (var context = new AseguradoraContext())
        {
            var validacion = context.Vehiculos.FirstOrDefault(v => v.id == Id);
            if(validacion != null){
                context.Vehiculos.Remove(validacion);
                context.SaveChanges();
            }
            else{
                throw new Exception("idinexistente");
            }
        }
    }
    public void modificarVehiculo(Vehiculo vehiculo)
    {
        using (var context = new AseguradoraContext())
        {
            var aux = context.Vehiculos.FirstOrDefault(v =>v.id == vehiculo.id);
            bool confirm = context.Titulares.FirstOrDefault(t=>t.id == vehiculo.titularId) != null;
            if((aux != null) && (confirm))
            { 
                aux.dominio = vehiculo.dominio;
                aux.fabricacion = vehiculo.fabricacion;
                aux.marca = vehiculo.marca;
                aux.titularId = vehiculo.titularId;
                context.SaveChanges();
            }
            else{
                throw new Exception("Error2");
            }
        }
    }
    public List<Vehiculo> listarVehiculo()
    {
        using(var context = new AseguradoraContext())
        {
            return context.Vehiculos.ToList();
        }
    }
}