namespace POO_Platzi;

abstract class Heroe
{
    public abstract string Nombre { get;set; }
    public abstract string SalvarElMundo();
    public string SalvarLaTierra()
    {
        return $"{Nombre} ha salvado la tierra";
    }
}