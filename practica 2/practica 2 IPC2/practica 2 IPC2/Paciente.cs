public class Paciente
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Especialidad { get; set; }
    public int TiempoAtencion { get; set; }
    public int TiempoEspera { get; set; }

    public Paciente(string nombre, int edad, string especialidad)
    {
        Nombre =nombre;
        Edad=edad;
        Especialidad=especialidad;

        switch (especialidad)
        {
            case "Medicina General":
                TiempoAtencion= 10;
                break;

            case "Pediatría":
                TiempoAtencion =15;
                break;

            case "Ginecología":
                TiempoAtencion =20;
                break;

            case "Dermatología":
                TiempoAtencion=25;
                break;
        }
    }

    public int TiempoTotal
    {
        get { return TiempoEspera + TiempoAtencion; }
    }
}