using CitasMedicas;

Console.WriteLine("1. Crear una cita\n2. Mostrar datos de citas\n3. Modificacion masiva\n4. Salir");
int opcion = int.Parse(Console.ReadLine());

Cita[] lista = new Cita[0];
do
{
    switch (opcion)
    {
        case 1:
            Array.Resize(ref lista, lista.Length + 1);
            lista[lista.Length - 1] = new Cita();
            lista[lista.Length- 1] = CitaUtil.Crear();
            Console.WriteLine("\n¡Cita añadida!");
            Console.WriteLine("Presiona cualquier tecla para volver al menu...");
            break;
        case 2:
            CitaUtil.Listar(lista);
            Console.WriteLine("\nPresiona cualquier tecla para volver al menu...");
            break;
        case 3:
            CitaUtil.ModMasivo(ref lista);
            Console.WriteLine("\nDatos modificados.");
            Console.WriteLine("Presiona cualquier tecla para volver al menu...");
            break;
    }
} while (opcion != 4);