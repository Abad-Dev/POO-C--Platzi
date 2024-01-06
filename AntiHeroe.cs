namespace POO_Platzi;

class AntiHeroe : SuperHeroe
{
    public string RealizarAccionDeAntiHeroe(string accion)
    {
        return $"El Antiheroe {NombreEIdentidadSecreta} ha realizado: {accion}";
    }
}