using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace TareaDW
{
    public partial class Alta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("insert into Visita(Nombre,Apellido, CUI, Fam_Visitar, Telefono, Direccion, Nacimiento) values('" +
                  TextBoxNombre.Text + "','" +
                  TextBoxApellido.Text + "','" +
                  TextBoxCUI.Text + "','" +
                  TextBoxFAM_VISITAR.Text + "','" +
                  TextBoxTelefono.Text + "','" +
                  TextBoxDireccion.Text + "','" +
                  TextBoxFechaNac.Text + "')", conexion);
            comando.ExecuteNonQuery();
            LabelExito.Text = "Se registro visita";
            conexion.Close();
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}