namespace Tareas;

public class Tarea {
    //Campos
    private int tareaID;
    private string descripcion;
    private int duracion;
    //Constructor
    public Tarea(int Id, string Descripcion, int Duracion) {
        tareaID = Id;
        descripcion = Descripcion;
        duracion = Duracion;
    }
    //Propiedades
    public int TareaID {
        get => tareaID;
    }
    public string Descripcion {
        get => descripcion; 
    }
}