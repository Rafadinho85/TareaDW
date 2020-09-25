using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace TareaDW
{
    public partial class modificaciones : System.Web.UI.Page
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
            {
                this.TextBox2.Text = registro["Apellido"].ToString();
                this.TextBox3.Text = registro["CUI"].ToString();
                this.TextBox4.Text = registro["Fam_Visitar"].ToString();
                this.TextBox5.Text = registro["Telefono"].ToString();
                this.TextBox6.Text = registro["Direccion"].ToString();
                this.TextBox7.Text = registro["Nacimiento"].ToString();

            }
            else
                this.Label1.Text = "No existe una Visita con dicho nombre";
            conexion.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("update Visita set " +
                     "Apellido='" + this.TextBox2.Text +
                     "',CUI='" + this.TextBox3.Text +
                       "',Fam_Visitar='" + this.TextBox4.Text +
                         "',Telefono='" + this.TextBox5.Text +
                           "',Direccion='" + this.TextBox6.Text +
                             "',Nacimiento='" + this.TextBox7.Text +
                     "' where Nombre='" + this.TextBox1.Text + "'", conexion);
            int cantidad = comando.ExecuteNonQuery();
            if (cantidad == 1)
                this.Label2.Text = "Datos Modificados";
            else
                this.Label2.Text = "No existe el usuario";
            conexion.Close();
        }
    }
}