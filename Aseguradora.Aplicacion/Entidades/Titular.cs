namespace Aseguradora.Aplicacion.Entidades;
public class Titular : Persona{
    public string correo {get; set;} = "";
    public string direccion {get;set;} = "";
    public List<Vehiculo> vehiculosTitular {get;set;} = new List<Vehiculo>();

    public Titular(){
        
    }


    public Titular(string correo,string direccion,int dni, string nombre, string apellido, string tel) : base(dni, nombre, apellido,tel){
        this.correo = correo;
        this.direccion = direccion;
    }


    public override string ToString()
    {
        return(base.ToString() + (this.direccion != "" ? "\nDireccion: "+this.direccion : "") + (this.direccion != "" ? "\nCorreo: " + this.correo : ""));
    }
}