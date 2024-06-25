namespace Tareas;
using Tareas;

public class Empleado {  //MOLDE
    string nombre;
    List<Tarea> tareasPendientes;
    List<Tarea> tareasRealizadas;
    public string Nombre {
        get => nombre;
    }
    //CONSTRUCTOR
    public Empleado(string parametroNombre, List<Tarea> TareasPendientes, List<Tarea> TareasRealizadas){
        nombre = parametroNombre;
        tareasRealizadas = TareasRealizadas;
        tareasPendientes = TareasPendientes;
    }
    //PROPIEDADES
    public List<Tarea> TareasPendientes {
        get => tareasPendientes;
    }
}