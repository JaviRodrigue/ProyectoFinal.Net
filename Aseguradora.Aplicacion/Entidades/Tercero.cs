namespace Aseguradora.Aplicacion.Entidades;
public class Tercero : Persona
{
    public string nombreAseguradora {get; set;} = "";
    public int siniestroid {get; set;}

    public Tercero(){
        
    }

    public Tercero(string nombreAseguradora,int idSiniestro,int dni, string nombre, string apellido, string tel) : base(dni, nombre,apellido,tel){
        this.nombreAseguradora = nombreAseguradora;
        this.siniestroid = idSiniestro;
    }
}