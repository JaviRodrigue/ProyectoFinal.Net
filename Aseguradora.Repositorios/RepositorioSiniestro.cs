namespace Aseguradora.Repositorio;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;
public class RepositorioSiniestro : IRepositorioSiniestro
{
    public void agregarSiniestro(Siniestro s)
    {
        using(var context = new AseguradoraContext()){
            var validacion = context.Polizas.FirstOrDefault(v => v.id == s.polizaid);
            bool fechaOc=context.Siniestros.FirstOrDefault(v => v.FechaOcurrencia == s.FechaOcurrencia) != null;
            if(validacion != null){
                if(!fechaOc){
                    if(validacion.inicioVigencia < s.FechaOcurrencia && validacion.finVigencia > s.FechaOcurrencia)
                    {
                        context.Siniestros.Add(s);
                        context.SaveChanges();
                    }
                    else{
                        throw new Exception("polizavencida");
                    }
                }
                else{
                    throw new Exception("siniestroigual");
                }
            }
            else{
                throw new Exception("polizanoencontrada");
            }
        }
    }

    public void eliminarSiniestro(int Id)
    {
        using(var context = new AseguradoraContext())
        {
            var validacion = context.Siniestros.FirstOrDefault(v => v.Id == Id);
            if(validacion != null)
            {
                context.Siniestros.Remove(validacion);
                context.SaveChanges();
            }
            else{
                throw new Exception("idnoencontrado");
            }
        }
    }
    public void modificarSiniestro(Siniestro s)
    {
        using( var context = new AseguradoraContext())
        {
            var aux = context.Siniestros.FirstOrDefault(v => v.Id == s.Id);
            bool validacion = context.Polizas.FirstOrDefault(p => s.polizaid == p.id) != null;
            if(aux != null)
            {
                if(validacion){
                    aux.polizaid = s.polizaid;
                    aux.FechaOcurrencia = s.FechaOcurrencia;
                    aux.FechaIngreso = DateTime.Now;
                    aux.DireccionHecho = s.DireccionHecho;
                    aux.DescAccidente = s.DescAccidente;
                    context.SaveChanges();
                }
                else{
                    throw new Exception("idpolizanoencontrada");
                }
            }
            else{
                throw new Exception("siniestronoecontrado");
            }
        }
    }

    public List<Siniestro> listarSiniestro()
    {
        using(var context = new AseguradoraContext())
        {
            return context.Siniestros.ToList();
        }
    }

}