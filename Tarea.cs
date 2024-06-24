namespace Tareas;

public class Tarea {
    //Campos
    private int tareaID;
    private string descripcion;
    private int duracion;
    //Constructor
    public void crearTarea(int id) {
        tareaID = id;
    }
}