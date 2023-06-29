namespace Aseguradora.Aplicacion.Entidades;
public class Poliza
{
    public int id {get; set;} 
    public int vehiculoid{get;set;}
    public double valorAsegurado {get; set;}
    public string franquicia {get;set;} = "";
    public string cobertura {get;set;} ="";
    public DateTime inicioVigencia {get; set;}
    public DateTime finVigencia {get; set;}
    public List<Siniestro> listaSiniestros {get;set;}= new List<Siniestro>();

    public Poliza(){
        
    }

    public Poliza (int vID, double vAseg, string f, string c, string iVigencia, string fVigencia){
        this.vehiculoid = vID;
        this.valorAsegurado = vAseg;
        this.franquicia = f;
        this.cobertura = c;
        this.inicioVigencia = DateTime.Parse(iVigencia);
        this.finVigencia = DateTime.Parse(fVigencia);
    }

    public Poliza (int ID,int vID, double vAseg, string f, string c, string iVigencia, string fVigencia){
        this.vehiculoid = vID;
        this.valorAsegurado = vAseg;
        this.franquicia = f;
        this.cobertura = c;
        this.inicioVigencia = DateTime.Parse(iVigencia);
        this.finVigencia = DateTime.Parse(fVigencia);
        this.id = ID;;
    }
    public override string ToString()
    {
        return($"ID:{this.id}\nVehiculo asegurado:{this.vehiculoid}\nvalor asegurado:{this.valorAsegurado}\nFranquicia:{this.franquicia}\nTipo de cobertura:{this.cobertura}\nInicio de vigencia:{this.inicioVigencia}\nFin de vigencia:{this.finVigencia}");
    }
}