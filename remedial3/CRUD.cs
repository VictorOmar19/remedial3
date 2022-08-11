using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades;

namespace remedial3
{
    public class CRUD
    {
        private Acceso_Datos AC = null;
        public CRUD(string connection)
        {
            AC = new Acceso_Datos(connection);
        }

        public List<TipoMaterial> ListaTipoMaterial(ref string mensaje, ref string mensajeC)//Metodo de la Lista Actualización
        {
            string comandoSql = "select * from TipoMaterial;", etiqueta = "BDConstructora";//Variables y Utilidades
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<TipoMaterial> actualizacion = new List<TipoMaterial>();//Creacion de una lista del tipo Actualizacion para trabajar

            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);//Se llena el DataSet con los datos de la BD
            if (dataSet != null)//Si e DataSet tiene datos entonces
            {
                dataTable = dataSet.Tables[0];//Se crea un DataTable y se llena con la informacion del DataSet
                actualizacion = dataTable.AsEnumerable().Select(row => new TipoMaterial//El datatable es como un numerable y se hace una seleccion, cada row será igual a un nuevo objeto de a clase seleccionada
                {//Por cada iterancia vamos a pasar los parámetros de mi objeto
                    IdTipo = row.Field<int>("ID_Tipo"),
                    Tipo = row.Field<string>("Tipo"),
                    Descripcion = row.Field<string>("Descripcion"),
                }).ToList();//Se añade la información a la Lista
            }
            return actualizacion;//Se retorna la Lista 
        }


        public List<dueño> ListaDueño(ref string mensaje, ref string mensajeC)//Metodo de la Lista Actualización
        {
            string comandoSql = "select * from Dueno;", etiqueta = "BDConstructora";//Variables y Utilidades
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<dueño> actualizacion = new List<dueño>();//Creacion de una lista del tipo Actualizacion para trabajar

            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);//Se llena el DataSet con los datos de la BD
            if (dataSet != null)//Si e DataSet tiene datos entonces
            {
                dataTable = dataSet.Tables[0];//Se crea un DataTable y se llena con la informacion del DataSet
                actualizacion = dataTable.AsEnumerable().Select(row => new dueño//El datatable es como un numerable y se hace una seleccion, cada row será igual a un nuevo objeto de a clase seleccionada
                {//Por cada iterancia vamos a pasar los parámetros de mi objeto
                    IdDueno = row.Field<int>("ID_Dueno"),
                    Nombre_Dueno = row.Field<string>("Nombre_Dueno"),
                    Telefono = row.Field<string>("Telefono"),
                    Correo = row.Field<string>("Correo"),
                    Empresa = row.Field<string>("Empresa"),
                }).ToList();//Se añade la información a la Lista
            }
            return actualizacion;//Se retorna la Lista 
        }

        public List<Encargado> ListaEncargado(ref string mensaje, ref string mensajeC)//Metodo de la Lista Actualización
        {
            string comandoSql = "select * from EncargadoObra;", etiqueta = "BDConstructora";//Variables y Utilidades
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<Encargado> actualizacion = new List<Encargado>();//Creacion de una lista del tipo Actualizacion para trabajar

            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);//Se llena el DataSet con los datos de la BD
            if (dataSet != null)//Si e DataSet tiene datos entonces
            {
                dataTable = dataSet.Tables[0];//Se crea un DataTable y se llena con la informacion del DataSet
                actualizacion = dataTable.AsEnumerable().Select(row => new Encargado//El datatable es como un numerable y se hace una seleccion, cada row será igual a un nuevo objeto de a clase seleccionada
                {//Por cada iterancia vamos a pasar los parámetros de mi objeto
                    IdEncargado = row.Field<int>("ID_Encargado"),
                    Nombre_Encargado = row.Field<string>("Nom_Encargado"),
                    Telefono1 = row.Field<string>("Telefono1"),
                    Telefono2 = row.Field<string>("Telefono2"),
                    Correo_Encar = row.Field<string>("Correo_Encar"),
                }).ToList();//Se añade la información a la Lista
            }
            return actualizacion;//Se retorna la Lista 
        }

        public List<obra> ListaObra(ref string mensaje, ref string mensajeC)//Metodo de la Lista Actualización
        {
            string comandoSql = "select * from Obra;", etiqueta = "BDConstructora";//Variables y Utilidades
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<obra> actualizacion = new List<obra>();//Creacion de una lista del tipo Actualizacion para trabajar

            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);//Se llena el DataSet con los datos de la BD
            if (dataSet != null)//Si e DataSet tiene datos entonces
            {
                dataTable = dataSet.Tables[0];//Se crea un DataTable y se llena con la informacion del DataSet
                actualizacion = dataTable.AsEnumerable().Select(row => new obra//El datatable es como un numerable y se hace una seleccion, cada row será igual a un nuevo objeto de a clase seleccionada
                {//Por cada iterancia vamos a pasar los parámetros de mi objeto
                    IdObra = row.Field<int>("ID_Obra"),
                    Nombre_Obra = row.Field<string>("Nom_Obra"),
                    Direccion = row.Field<string>("Direccion"),
                    fecha_inicio = row.Field<DateTime>("Fecha_Inicio"),
                    fecha_fin = row.Field<DateTime>("Fecha_Termino"),
                    idDueño = row.Field<int>("ID_Dueno"),
                    id_Encargado = row.Field<int>("ID_Encargado"),
                }).ToList();//Se añade la información a la Lista
            }
            return actualizacion;//Se retorna la Lista 
        }



        public bool InsertarMaterial(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            bool respuesta = false;

            string instrccion = "INSERT INTO Material (Descripcion_Mat, Marca, Presentacion, ID_Tipo) " +
                "values (@Descripcion_Mat, @Marca, @Presentacion, @ID_Tipo)";
            SqlParameter[] info = new SqlParameter[]
            {

                new SqlParameter("@Descripcion_Mat",SqlDbType.VarChar, 60),
                new SqlParameter("@Marca",SqlDbType.VarChar, 40),
                new SqlParameter("@Presentacion",SqlDbType.VarChar, 60),
                new SqlParameter("@ID_Tipo",SqlDbType.Int),
            };

            info[0].Value = nuevoDatos[0];
            info[1].Value = nuevoDatos[1];
            info[2].Value = nuevoDatos[2];
            info[3].Value = Convert.ToInt32(nuevoDatos[3]);
            respuesta = AC.BaseSegura(instrccion, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, info);
            return respuesta;
        }

        public bool InsertarObra(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            bool respuesta = false;

            string instrccion = "INSERT INTO Obra (Nom_Obra, Direccion, Fecha_Inicio, Fecha_Termino, ID_Dueno, ID_Encargado) " +
                "values (@Nom_Obra, @Direccion, @Fecha_Inicio, @Fecha_Termino, @ID_Dueno, @ID_Encargado)";
            SqlParameter[] info = new SqlParameter[]
            {

                new SqlParameter("@Nom_Obra",SqlDbType.VarChar, 40),
                new SqlParameter("@Direccion",SqlDbType.VarChar, 60),
                new SqlParameter("@Fecha_Inicio",SqlDbType.DateTime),
                new SqlParameter("@Fecha_Termino",SqlDbType.DateTime),
                new SqlParameter("@ID_Dueno",SqlDbType.Int),
                new SqlParameter("@ID_Encargado",SqlDbType.Int),
            };

            info[0].Value = nuevoDatos[0];
            info[1].Value = nuevoDatos[1];
            info[2].Value = Convert.ToDateTime(nuevoDatos[2]);
            info[3].Value = Convert.ToDateTime(nuevoDatos[3]);
            info[4].Value = Convert.ToInt32(nuevoDatos[4]);
            info[5].Value = Convert.ToInt32(nuevoDatos[5]);
            respuesta = AC.BaseSegura(instrccion, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, info);
            return respuesta;
        }

        public bool InsertarProvedorMaterial(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            bool respuesta = false;

            string instrccion = "INSERT INTO Provee_De_Materi_Obra (Recibo, Entrega, Cantidad, Fecha_Entre, Precio, ID_Obra , ID_Material, ID_Proveedor) " +
                "values (@Recibo, @Entrega, @Cantidad, @Fecha_Entre, @Precio, @ID_Obra , @ID_Material, @ID_Proveedor)";
            SqlParameter[] info = new SqlParameter[]
            {

                new SqlParameter("@Recibo",SqlDbType.VarChar, 30),
                new SqlParameter("@Entrega",SqlDbType.VarChar, 30),
                new SqlParameter("@Cantidad",SqlDbType.Int),
                new SqlParameter("@Fecha_Entre",SqlDbType.DateTime),
                new SqlParameter("@Precio",SqlDbType.Float),
                new SqlParameter("@ID_Obra",SqlDbType.Int),
                new SqlParameter("@ID_Material",SqlDbType.Int),
                new SqlParameter("@ID_Proveedor",SqlDbType.Int),
            };

            info[0].Value = nuevoDatos[0];
            info[1].Value = nuevoDatos[1];
            info[2].Value = Convert.ToInt32(nuevoDatos[2]);
            info[3].Value = Convert.ToDateTime(nuevoDatos[3]);
            info[4].Value = nuevoDatos[4];
            info[5].Value = Convert.ToInt32(nuevoDatos[5]);
            info[6].Value = Convert.ToInt32(nuevoDatos[6]);
            info[7].Value = Convert.ToInt32(nuevoDatos[7]);
            respuesta = AC.BaseSegura(instrccion, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, info);
            return respuesta;
        }
        public bool EliminarObra(ref string Mensaje, ref string MensajeC, int ID)
        {
            bool respuesta = false;

            string instruccion = "DELETE from Obra where ID_Obra = @ID_Obra";

            SqlParameter[] evaluacion = new SqlParameter[]
            {
                new SqlParameter("@ID_Obra",SqlDbType.Int)
            };

            evaluacion[0].Value = ID;

            respuesta = AC.BaseSegura(instruccion, AC.ConnectionEstablecida(ref MensajeC), ref Mensaje, evaluacion);

            return respuesta;
        }
    }
}
