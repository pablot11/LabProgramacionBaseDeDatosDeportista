using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace pryTorresBaseDeDatos
{
    internal class clsDeportista
    {

        //Creacion de objetos
        //Nos permite conectar a la base de datos
        private OleDbConnection conexionBd = new OleDbConnection();
        //Con este objeto enviamos una orden a la BD
        private OleDbCommand comandoBd = new OleDbCommand();
        //Nos sirve para adaptar los datos de la BD a datos reconocidos por .NET
        private OleDbDataAdapter AdaptadorDeDatosBd = new OleDbDataAdapter();
        //variable para indicar la ruta de la BD
        private string varRutaAccesoBD = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";
        //Variable que contiene el nombre de una tabla
        private string varTabla = "DEPORTISTA";

        //Declaracion de variables privadas

        private string CodigoDeportista;
        private string NombreDeportista;
        private string ApellidoDeportista;
        private string DireccionDeportista;
        private Int32 TelefonoDeportista;
        private Int32 EdadDeportista;
        private string Deporte;



        //Declaracion de propiedades
        public string CDeportista
        {
            //Retorna el valor de la variable CodigoDeportista 
            get { return CodigoDeportista; }
            set { CodigoDeportista = value; }
        }
        public string Nombre
        {
            get { return NombreDeportista; }
            set { NombreDeportista = value; }
        }
        public string Apellido
        {
            get { return ApellidoDeportista; }
            set { ApellidoDeportista = value; }
        }
        public string Direccion
        {
            get { return DireccionDeportista; }
            set { DireccionDeportista = value; }
        }
        public Int32 Telefono
        {
            get { return TelefonoDeportista; }
            set { TelefonoDeportista = value; }
        }
        public Int32 Edad
        {
            get { return EdadDeportista; }
            set { EdadDeportista = value; }
        }
        public string Deportes
        {
            get { return Deporte; }
            set { Deporte = value; }
        }



        public void Listar(DataGridView dgvConsultasDeportista)
        {
            //Recibe la ruta de la BD para conectarse
            conexionBd.ConnectionString = varRutaAccesoBD;
            //Abre la conexion de la BD, es un canal
            conexionBd.Open();
            //Necesitamos mndar una orden para que nos traiga datos de la BD 
            //usamos el objeto comando
            //Indicamos la conexion que tiene que utilizar
            comandoBd.Connection = conexionBd;
            //Indicamos el tipo de comando
            //Trae una tabla el comando
            comandoBd.CommandType = CommandType.TableDirect;
            comandoBd.CommandText = varTabla;
            //El adaptador recibe los datos de la BD(lectura)
            AdaptadorDeDatosBd = new OleDbDataAdapter(comandoBd);
            //objeto que contiene lo que tiene la tabla, es una tabla virtual
            DataSet LectorDataSet = new DataSet();
            //Adaptamos los datos al data set
            AdaptadorDeDatosBd.Fill(LectorDataSet);
            //Enviamos los datos del DataSet a la grilla, es 0 porque es la unica tabla
            //que trajo el dataset
            //DataSource sirve para tomar el contenido de un DataSet
            dgvConsultasDeportista.DataSource = LectorDataSet.Tables[0];
            conexionBd.Close();

        }

        public void Buscar(string varCodigo)
        {
            try
            {
                //Recibe la ruta de la BD para conectarse
                conexionBd.ConnectionString = varRutaAccesoBD;
                //Abre la conexion de la BD, es un canal
                conexionBd.Open();
                //Necesitamos mndar una orden para que nos traiga datos de la BD 
                //usamos el objeto comando
                //Indicamos la conexion que tiene que utilizar
                comandoBd.Connection = conexionBd;
                //Indicamos el tipo de comando
                //Trae una tabla el comando
                comandoBd.CommandType = CommandType.TableDirect;
                comandoBd.CommandText = varTabla;
                //Objeto que toma lo del comando una vez ejecutado por eso ExecuteReader
                //Toda la tabla deportistas se envio al data reader(tabla virtual)
                OleDbDataReader Lector = comandoBd.ExecuteReader();
                //Si tenemos filas entra
                if (Lector.HasRows)
                {
                    //Mientras tenga datos en la tabla, esto lo va a leer
                    while (Lector.Read())
                    {
                        if (Lector.GetString(0) == varCodigo)
                        {
                            //Almacena a cada variable su respectivo dato de cada campo
                            //de la tabla
                            CodigoDeportista = Lector.GetString(0);
                            NombreDeportista = Lector.GetString(1);
                            ApellidoDeportista = Lector.GetString(2);
                            DireccionDeportista = Lector.GetString(3);
                            TelefonoDeportista = int.Parse(Lector.GetString(4));
                            EdadDeportista = Lector.GetInt32(5);
                            Deporte = Lector.GetString(6);
                        }
                    }
                }
                conexionBd.Close();
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.ToString());
            }

        }

        public void Eliminar(string varCodigoDeportista)
        {
            try
            {
                //Instruccion sql
                string Sql = "DELETE FROM DEPORTISTA WHERE ('" + varCodigoDeportista + "'= [CODIGO DEPORTISTA])";

                //Recibe la ruta de la BD para conectarse
                conexionBd.ConnectionString = varRutaAccesoBD;
                //Se conecta a la BD
                conexionBd.Open();
                //El comando toma la conexion
                comandoBd.Connection = conexionBd;
                //Se indica el tipo de comando el text es para instrucciones sql
                comandoBd.CommandType = CommandType.Text;
                //Se pasa la instruccion sql al comando
                comandoBd.CommandText = Sql;
                //ejecuta el comando
                comandoBd.ExecuteNonQuery();

                conexionBd.Close();
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(Convert.ToString(mensaje));
            }
        }


        public void Modificar(string CDeportista)
        {
            //Instruccion sql
            string Sql = "UPDATE DEPORTISTA SET [DIRECCION] = '" + Direccion + "', [TELEFONO] = " + Telefono + ", [EDAD] = " + Edad + ", [DEPORTE] = '" + Deporte + "' WHERE [CODIGO DEPORTISTA] = '" + CDeportista + "'";
            //Recibe la ruta de la BD para conectarse
            conexionBd.ConnectionString = varRutaAccesoBD;
            //Se conecta a la BD
            conexionBd.Open();

            //El comando toma la conexion
            comandoBd.Connection = conexionBd;
            //Se indica el tipo de comando el text es para instrucciones sql
            comandoBd.CommandType = CommandType.Text;
            //Se pasa la instruccion sql al comando
            comandoBd.CommandText = Sql;
            //ejecuta el comando
            comandoBd.ExecuteNonQuery();
            conexionBd.Close();
            MessageBox.Show("Cambios Guardados");
        }

       






    }

}
