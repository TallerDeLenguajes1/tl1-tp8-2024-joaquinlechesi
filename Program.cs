using System.Timers;
using Tareas;
using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lista de Tareas:");
//int nuevaTarea = new Tarea;

//List<Tarea> ListaTareas = new List<Tarea>();
//List<Tarea> ListaRealizadas = new List<Tarea>();
//void insertarTarea();

List<Empleado> empleados = new List<Empleado>();
string opcionString, descripcionTarea, duracionTareaString, nombreEmpleado, idSelecion;
int opcion, id = 0, idSeleccionInt = 0, duracionTareaInt;
//int numero
Random aleatorio = new Random();
do
{
    Console.WriteLine("Ingrese una opcion numerica:\n1 Agregar un empleado\n2 para listar los empleados con sus tareas.\n3 para marcar una tarea pendiente como realizada para un empleado\n4 para listar tareas pendientes y tareas realizadas por empleado\n5 para buscar una tarea por ID o por DESCRIPCION");
    opcionString = Console.ReadLine();
    int.TryParse(opcionString, out opcion);
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese el nombre del empleado:");
            nombreEmpleado = Console.ReadLine();
            var listaVacia = new List<Tarea>();
            Empleado nuevoEmpleado = new Empleado(nombreEmpleado, listaVacia, listaVacia);
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Ingrese la descripcion de la tarea:");
                descripcionTarea = Console.ReadLine();
                Console.WriteLine("Ingrese la duracion de la tarea:");
                duracionTareaString = Console.ReadLine();
                int.TryParse(duracionTareaString, out duracionTareaInt);
                Tarea nuevaTarea = new Tarea(id, descripcionTarea, duracionTareaInt);
                nuevoEmpleado.TareasPendientes.Add(nuevaTarea);
                id++;
            }
            empleados.Add(nuevoEmpleado);
            // Console.WriteLine("Ingrese la descripcion de la tarea:");
            // descripcionTarea = Console.ReadLine();
            // Console.WriteLine("Ingrese la duracion de la tarea:");
            // duracionTareaString = Console.ReadLine();
            // int.TryParse(duracionTareaString, out duracionTareaInt);
            // Tarea nuevaTarea = new Tarea(id, descripcionTarea, duracionTareaInt);
            // ListaTareas.Add(nuevaTarea);
            break;
        case 2:
            if (empleados.Count == 0)
            {
                Console.WriteLine("No hay empleados cargados.");
            }else
            {
                Console.WriteLine("Lista de empleados:");
                foreach (var empleado in empleados)
                {
                    Console.WriteLine(empleado.Nombre);
                    if (empleado.TareasPendientes.Count == 0)
                    {
                        Console.WriteLine("Empleado sin tareas pendientes");
                    }else
                    {
                        foreach (var Pendientes in empleado.TareasPendientes)
                        {
                            Console.WriteLine("ID DE LA TAREA: "+ Pendientes.TareaID + "\nDESCRIPCION DE LA TAREA: " + Pendientes.Descripcion);
                        }
                    }
                }
            }
            break;
        case 3:
            Console.WriteLine("Lista de empleados:");
            foreach (var empleado in empleados)
            {
                Console.WriteLine(empleado.Nombre);
                Console.WriteLine("Ingrese el ID de tarea pendiente que desea marcar como realizada:");
                foreach (var tareaPendiente in empleado.TareasPendientes)
                {
                    Console.WriteLine("ID DE LA TAREA: "+ tareaPendiente.TareaID + "\nDESCRIPCION DE LA TAREA: " + tareaPendiente.Descripcion);
                }
            }
            idSelecion = Console.ReadLine();
            int.TryParse(idSelecion, out idSeleccionInt);
            // foreach (var tareaPendiente in empleado.TareasPendientes)
            // {
                
            // }
            foreach (var empleado in empleados)
            {
                //Console.WriteLine(empleado.Nombre);
                //Console.WriteLine("Ingrese el ID de tarea pendiente que desea marcar como realizada:");
                foreach (var tareaPendiente in empleado.TareasPendientes)
                {
                    if (tareaPendiente.TareaID == idSeleccionInt)
                    {
                        empleado.TareasRealizdas.Add(tareaPendiente);
                        empleado.TareasPendientes.Remove(tareaPendiente);
                    }
                }
            }
            Console.WriteLine("");
            break;
        default:
            Console.WriteLine("Opcion incorrecta.");
            break;
    }
    id++;
} while (opcion != 0);