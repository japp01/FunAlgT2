using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicas
{
        internal class CitaUtil
        { 
            public static Cita Crear()
            {
                Cita c = new Cita();
                Console.Write("Codigo: ");
                c.Persona.Codigo = int.Parse(Console.ReadLine());
                Console.Write("Nombre: ");
                c.Persona.Nombre = Console.ReadLine();
                Console.Write("Universdidad: ");
                c.Persona.Universidad = Console.ReadLine();
                Console.Write("Numero: ");
                c.Numero = int.Parse(Console.ReadLine());
                Console.Write("Enfermedad: ");
                c.Enfermedad = Console.ReadLine();
                Console.Write("Precio: ");
                c.precio = double.Parse(Console.ReadLine());
                return c;
            }
            public static void Listar(Cita[] lista)
            {
                for (int i = 0; i < lista.Length; i++)
                {
                    lista.ToString();
                }
            }
            public static void ModMasivo(ref Cita[] lista)
            {
                Console.Write("Texto a modificar: ");
                string txt = Console.ReadLine();
                Console.Write("Escriba el texto modificado: ");
                string txt2 = Console.ReadLine();

                for(int i = 0;i < lista.Length; i++)
                {
                    if (lista[i].Persona.Universidad == txt)
                    {
                        lista[i].Persona.Universidad = txt2;
                    }
                }
            }
        }
}
