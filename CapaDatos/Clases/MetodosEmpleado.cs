using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Modelo;

namespace CapaDatos.Clases
{
    public class MetodosEmpleado
    {
        PractExa1Entities db = new PractExa1Entities();
        public bool Ingreso(empleado emp)
        {
            db.empleado.Add(emp);
            db.SaveChanges();
            return true;
        }
    }
}
