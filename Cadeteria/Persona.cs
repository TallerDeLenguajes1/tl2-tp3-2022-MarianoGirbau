public class Persona{
    private int ID { get; set; }
    private string nombre { get; set; }
    private string direccion { get; set; }
    private long telefono { get; set; }

    public Persona(int ID, string nombre, string direccion, long telefono){

        this.ID = ID;
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;

    }


}