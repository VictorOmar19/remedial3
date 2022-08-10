using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using entidades;
using dll;
using System.Configuration;
using remedial3;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Logica_Negocios LN = null;
        List<TipoMaterial> lista_TipoMaterial = new List<TipoMaterial>();
        List<dueño> lista_dueño = new List<dueño>();
        List<Encargado> lista_Encargado = new List<Encargado>();
        string mensaje = "", mensajeC = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocios(ConfigurationManager.ConnectionStrings["BDConstructora"].ConnectionString);
                Session["negocioServer"] = LN;

                lista_TipoMaterial = LN.L_TipoMaterial(ref mensaje, ref mensajeC);
                DropDownList2.Items.Add("");
                for (int i = 0; i < lista_TipoMaterial.Count; i++)
                {
                    DropDownList2.Items.Add(lista_TipoMaterial[i].IdTipo.ToString());
                }

                lista_dueño = LN.L_Dueño(ref mensaje, ref mensajeC);
                DropDownList3.Items.Add("");
                for (int i = 0; i < lista_dueño.Count; i++)
                {
                    DropDownList3.Items.Add(lista_dueño[i].IdDueno.ToString());
                }

                lista_Encargado = LN.L_Encargado(ref mensaje, ref mensajeC);
                DropDownList4.Items.Add("");
                for (int i = 0; i < lista_Encargado.Count; i++)
                {
                    DropDownList4.Items.Add(lista_Encargado[i].IdEncargado.ToString());
                }



            }
            else
            {
                LN = (Logica_Negocios)Session["negocioServer"];
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = LN.tablaMaterial(ref mensaje, ref mensajeC);
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] datos = new string[4];

            datos[0] = TextBox1.Text;
            datos[1] = TextBox2.Text;
            datos[2] = TextBox3.Text;
            datos[3] = DropDownList2.SelectedItem.Text;

            try
            {
                LN.insertar_Material(datos, ref mensaje, ref mensajeC);
                Label1.Text = "Se agregaron los datos con exito";
            }
            catch
            {
                Label1.Text = "Error al insertar los datos ";
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            string[] datos = new string[6];

            datos[0] = TextBox4.Text;
            datos[1] = TextBox5.Text;
            datos[2] = Calendar1.SelectedDate.ToString();
            datos[3] = Calendar2.SelectedDate.ToString();
            datos[4] = DropDownList3.SelectedItem.Text;
            datos[5] = DropDownList4.SelectedItem.Text;

            try
            {
                LN.insertar_Obra(datos, ref mensaje, ref mensajeC);
                Label2.Text = "Se agregaron los datos con exito";
            }
            catch
            {
                Label2.Text = "Error al insertar los datos ";
            }
        }
    }
}