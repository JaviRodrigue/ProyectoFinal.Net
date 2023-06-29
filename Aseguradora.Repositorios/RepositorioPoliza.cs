namespace Aseguradora.Repositorio;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

public class RepositorioPoliza : IRepositorioPoliza
{
    public void agregarPoliza(Poliza p)
    {
        using( var context = new AseguradoraContext())
        {
            bool validacion = (context.Polizas.FirstOrDefault(v => v.vehiculoid == p.vehiculoid) != null);
            bool valVehi = (context.Vehiculos.FirstOrDefault(ve => ve.id == p.vehiculoid) != null);
            if(!validacion){ 
                if(valVehi){
                    context.Polizas.Add(p);
                    context.SaveChanges();
                }
                else{
                    throw new Exception("IDnoexiste");
                }
            }
            else{
                throw new Exception("Poliza de vehiculo existente");
            }
        }
    }

    public void eliminarPoliza(int Id)
    {
        using( var context = new AseguradoraContext())
        {
            var auxPoliza = context.Polizas.FirstOrDefault(a => a.id == Id);
            if(auxPoliza != null)
            {
                context.Polizas.Remove(auxPoliza);
                context.SaveChanges();
            }
            else{
                throw new Exception("idnoencontrada");
            }
        }
    }

    public void modificarPoliza(Poliza poliza)
    {
        using(var context = new AseguradoraContext())
        {
            var auxPoliza = context.Polizas.FirstOrDefault(p => p.id == poliza.id);
            bool valVehi = context.Vehiculos.FirstOrDefault(v => v.id == poliza.vehiculoid) != null;
            if(auxPoliza != null)
            {
                if(valVehi){
                    auxPoliza.vehiculoid = poliza.vehiculoid;
                    auxPoliza.valorAsegurado = poliza.valorAsegurado;
                    auxPoliza.franquicia = poliza.franquicia;
                    auxPoliza.cobertura = poliza.cobertura;
                    auxPoliza.inicioVigencia = poliza.inicioVigencia;
                    auxPoliza.finVigencia = poliza.finVigencia;
                    context.SaveChanges();
                }
                else{
                    throw new Exception("idvehiculonoencontrado");
                }
            }
            else{
                throw new Exception("idpolizanoencontrada");
            }
        }
    }
    public List<Poliza> listarPoliza()
    {
        using( var context = new AseguradoraContext())
        {
            return context.Polizas.ToList();
        }
    }
}