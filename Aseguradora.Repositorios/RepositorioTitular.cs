namespace Aseguradora.Repositorio;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
using Microsoft.EntityFrameworkCore;
public class RepositorioTitular : IRepositorioTitular
{
    public void agregarTitular(Titular t)
    {
        if(t.apellido == "" || t.nombre == "" || t.dni == 0 ){
            throw new Exception ("Campos vacios");
        }
        using(var context = new AseguradoraContext()){
            bool validacion = context.Titulares.FirstOrDefault(v => v.dni == t.dni) != null;
            if(!validacion)
            {
                context.Titulares.Add(t);
                context.SaveChanges();
            }
            else{
                throw new Exception("DNI ya existente");
            }
        }
    }

    public void eliminarTitular(int id)
    {
        if (id==0)
        {
            throw new Exception("El ID no puede ser 0");
        }
        using(var context = new AseguradoraContext())
        {
            var validacion = context.Titulares.FirstOrDefault(v => v.id == id);
            
            if(validacion != null)
            {
                
                context.Titulares.Remove(validacion);
                context.SaveChanges();
            }
            else{
                throw new Exception("ID no encontrado");
            }
        }
    }
    public void modificarTitular(Titular t)
    {
        if(t.apellido == "" || t.nombre == "" || t.dni == 0 ){
            throw new Exception ("Campos vacios");
        }
        using( var context = new AseguradoraContext())
        {
            var aux = context.Titulares.FirstOrDefault(v => v.dni == t.dni);
            if(aux != null)
            {
                aux.nombre = t.nombre;
                aux.apellido = t.apellido;
                aux.direccion = t.direccion;
                aux.tel = t.tel;
                aux.correo = t.correo;
                context.SaveChanges();
            }else{
                throw new Exception("DNI no existente");
            }
        }
    }
    public List<Vehiculo> listarTitularesConVehiculos(int id)
    {
        using(var context =  new AseguradoraContext())
        {
            List<Vehiculo> listadoV = new List<Vehiculo>();
            listadoV = context.Vehiculos.Where(vehi => vehi.titularId == id ).ToList();

            return listadoV;
        }
    }


    public List<Titular> listarTitular()
    {
        using(var context = new AseguradoraContext())
        {
            return context.Titulares.ToList();
        }
    }
    public Titular? obtenerTitular(int id)
    {
        using(var context = new AseguradoraContext())
        {
            return(context.Titulares?.FirstOrDefault(t=> t.id == id) ?? null);
        }
    }

}