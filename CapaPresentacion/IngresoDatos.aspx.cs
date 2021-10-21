using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos.Modelo;
using CapaDatos.Clases;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class IngresoDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        MetodosLogica logicos = new MetodosLogica();
        EntidadEmpleado entemp = new EntidadEmpleado();


        protected void btn_Ingreso_Click(object sender, EventArgs e)
        {
            TxtSalBruto.Text = Convert.ToString(Convert.ToUInt32(TxtSalHora.Text) * Convert.ToUInt32(TxtHoras.Text));
            entemp.codigo_empleado = Convert.ToInt32(TxtCodigo.Text);
            entemp.Nombre = TxtNombre.Text;
            entemp.Horas_laboradas = Convert.ToInt32(TxtHoras.Text);
            entemp.Salario_Hora = Convert.ToInt32(TxtSalHora);
            entemp.Salario_Bruto = Convert.ToInt32(TxtSalBruto.Text);
            logicos.Ingreso(entemp);
        }

    }
}
