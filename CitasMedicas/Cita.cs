using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicas
{
    internal class Cita
    {
        public int Numero {  get; set; }
        public Estudiante Persona { get; set; }
        public string Enfermedad {  get; set; }
        public double precio { get; set; }
        public override string ToString()
        {
            return $"{Persona.ToString()}\nNumero: {Numero}\nEnfermedad: {Enfermedad}\nPrecio: {precio}\n\n";
        }
    }
}
