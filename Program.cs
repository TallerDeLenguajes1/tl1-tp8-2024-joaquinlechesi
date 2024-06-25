using Tareas;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lista de Tareas:");
//int nuevaTarea = new Tarea;

List<Tarea> ListaTareas = new List<Tarea>();

void insertarTarea();

string opcionString;
int opcion;

do
{
    Console.WriteLine("Ingrese una opcion numerica:\n1 para agregar una tarea\n2 para marcar una tarea pendiente como realizada\n3 para listar tareas pendientes y tareas realizadas\n4 para buscar una tarea por ID o por DESCRIPCION");
    opcionString = Console.ReadLine();
    int.TryParse(opcionString, out opcion);
    switch (opcion)
    {
        case 1:
            
            break;
        default:
            Console.WriteLine("Opcion incorrecta.");
            break;
    }
} while (opcion != 0);