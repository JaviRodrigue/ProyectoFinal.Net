namespace Aseguradora.Aplicacion.Entidades;
public class Persona
{
    public int id {get; set;}
    public string nombre {get; set;} = "";
    public string apellido {get; set;} ="";
    public string tel {get; set;} = "";
    public int dni {get; set;}


    public Persona(){
        
    }

    public Persona(int dni, string nombre, string apellido,string tel ){
        this.dni = dni;
        this.nombre = nombre;
        this.apellido = apellido;
        this.tel = tel;
    }

    public override string ToString()
    {
        return ($"Id: {this.id}\nNombre: {this.nombre}\nApellido: {this.apellido}" + (this.tel != "000" ? "\nTelefono: " + this.tel :"" + "\nDNI: " + this.dni));
    }
}