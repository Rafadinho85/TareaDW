using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TareaDW
{
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
        SqlConnection conexion = new SqlConnection(s);
        conexion.Open();
        SqlCommand comando = new SqlCommand("select Nombre,Apellido, CUI, Fam_Visitar, Telefono, Direccion, Nacimiento from Visita " +
              " where Nombre='" + this.TextBox1.Text + "'", conexion);
        SqlDataReader registro = comando.ExecuteReader();
        if (registro.Read())
            this.Label2.Text = "Nombre:" + registro["Nombre"] + "<br>" +
                    "Apellido:" + registro["Apellido"] + "<br>" +
                    "CUI:" + registro["CUI"] + "<br>" +
                    "Familia a visitar:" + registro["Fam_Visitar"] + "<br>" +
                    "Telefono:" + registro["Telefono"] + "<br>" +
                    "Direccion:" + registro["Direccion"] + "<br>" +
                               "Nacimiento:" + registro["Nacimiento"];
        else
            this.Label2.Text = "No existe un usuario con dicho nombre";
        conexion.Close();
        }
    }
}