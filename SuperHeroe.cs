using System.Text;

namespace POO_Platzi;

class SuperHeroe : Heroe
{
    public override string Nombre { get;set; }
    public string NombreEIdentidadSecreta { get;set; }
    public List<SuperPoder> SuperPoderes { get;set; }
    public bool PuedeVolar { get;set; }

    public override string SalvarElMundo()
    {
        return $"{NombreEIdentidadSecreta} ha salvado el mundo";
    }

    public string UsarSuperPoderes()
    {
        StringBuilder sb = new StringBuilder();
        foreach (SuperPoder item in SuperPoderes)
        {
            sb.AppendLine($"{NombreEIdentidadSecreta} esta usando el super poder {item.Nombre}");
        }
        return sb.ToString();
    }
}