namespace Aseguradora.Aplicacion.Entidades;
public class Siniestro
{
    public int Id {get;set;}
    public int polizaid {get; set;}
    public DateTime FechaIngreso{get;set;} = DateTime.Now;
    public DateTime FechaOcurrencia {get;set;}
    public string DireccionHecho {get; set;} ="";
    public string DescAccidente {get; set;} = "";
    public List<Tercero> listaTerceros {get;set;} = new List<Tercero>();

    public Siniestro(){
        
    }
    public Siniestro(int idpoliza,DateTime fechaOcurrencia, string direccion, string descripcion)
    {
        this.polizaid = idpoliza;
        this.FechaOcurrencia = fechaOcurrencia;
        this.DireccionHecho = direccion;
        this.DescAccidente = descripcion;
    }
}