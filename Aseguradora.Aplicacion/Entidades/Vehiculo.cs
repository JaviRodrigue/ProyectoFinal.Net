namespace Aseguradora.Aplicacion.Entidades;
public class Vehiculo
{
    public int id {get;set;}
    public string dominio {get;set;} ="";
    public string marca {get;set;}="";
    public string fabricacion {get; set;}="";
    public int titularId {get;set;}

    public List<Poliza> listaPolizas {get;set;} = new List<Poliza>();

    public Vehiculo(){

    }
    public Vehiculo(string dominio, string marca, string fabricacion, int titular){
        this.dominio = dominio;
        this.marca = marca;
        this.fabricacion = fabricacion;
        this.titularId = titular;
    }
    public override string ToString(){
        return($"ID:{this.id}\nDominio:{this.dominio}\nMarca:{this.marca}\nFavricacion:{this.fabricacion}\nTitular:{this.titularId}");
    }
}