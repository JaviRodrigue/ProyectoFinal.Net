namespace Aseguradora.Repositorio;
public static class CrearBaseDato
{
    public static void Crear(){
        using(var context = new AseguradoraContext())
        {
            context.Database.EnsureCreated();
        }
    }
}