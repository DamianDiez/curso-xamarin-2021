using System.Threading.Tasks;
using System.Collections.Generic;
using Demo0456_Interfaces_Arreglos_Colecciones.Clases;

namespace Demo0456_Interfaces_Arreglos_Colecciones.Interfaces
{
    public interface IDatos
    {
        Task<List<Empleado>> LeerDatos(string ruta);
    }
}
