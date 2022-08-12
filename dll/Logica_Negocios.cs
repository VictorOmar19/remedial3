using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades;
using System.Data;
using System.Data.SqlClient;
using remedial3;

namespace dll
{
    public class Logica_Negocios
    {
        private Acceso_Datos AC = null;

        private CRUD OPC = null;

        public Logica_Negocios(string connection)
        {
            AC = new Acceso_Datos(connection);
            OPC = new CRUD(connection);
        }

        public List<TipoMaterial> L_TipoMaterial(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaTipoMaterial(ref mensaje, ref mensajeC);
        }

        public List<dueño> L_Dueño(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaDueño(ref mensaje, ref mensajeC);
        }

        public List<Encargado> L_Encargado(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaEncargado(ref mensaje, ref mensajeC);
        }
        public List<obra> L_Obra(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaObra(ref mensaje, ref mensajeC);
        }

        public string insertar_Material(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarMaterial(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "funciona";
            }
            return resp;
        }
        public string insertar_Obra(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarObra(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "funciona";
            }
            return resp;
        }
        public string insertar_ProveedorMateri(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarProvedorMaterial(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "funciona";
            }
            return resp;
        }



        public DataTable tablaMaterial(ref string mensaje, ref string mensajeC)
        {
            string comandoMySql = "select * from Material;", etiqueta = "BDConstructora";
            DataSet dataSet = null;
            DataTable dataTable = null;


            dataSet = AC.LecturaSet(comandoMySql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
            }
            return dataTable;

        }


        public DataTable tablaviewMaterial(ref string mensaje, ref string mensajeC)
        {
            string comandoMySql = "select * from ViewMAterial;", etiqueta = "BDConstructora";
            DataSet dataSet = null;
            DataTable dataTable = null;


            dataSet = AC.LecturaSet(comandoMySql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
            }
            return dataTable;

        }

        public string Elim_Obra(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.EliminarObra(ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }


        public DataTable tablaObra(ref string mensaje, ref string mensajeC)
        {
            string comandoMySql = "select * from Obra;", etiqueta = "BDConstructora";
            DataSet dataSet = null;
            DataTable dataTable = null;


            dataSet = AC.LecturaSet(comandoMySql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
            }
            return dataTable;

        }

    }
}
