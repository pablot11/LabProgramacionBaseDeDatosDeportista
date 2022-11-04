using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTorresBaseDeDatos
{
    internal class clsEntrenador
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
        private string varTabla = "ENTRENADORES";


        public bool varBandera = true;
        private string CodigoEntrenador;
        private string NombreEntrenador;
        private string ApellidoEntrenador;
        private string DireccionEntrenador;
        private string ProvinciaEntrenador;
        private string Deporte;
        //Declaracion de propiedades
        public string CEntrenador
        {
            //Retorna el valor de la variable CodigoEntrenador
            get { return CodigoEntrenador; }
            set { CodigoEntrenador = value; }
        }
        public string Nombre
        {
            get { return NombreEntrenador; }
            set { NombreEntrenador = value; }
        }
        public string Apellido
        {
            get { return ApellidoEntrenador; }
            set { ApellidoEntrenador= value; }
        }
        public string Direccion
        {
            get { return DireccionEntrenador; }
            set { DireccionEntrenador= value; }
        }
        public string Provincia
        {
            get { return ProvinciaEntrenador; }
            set { ProvinciaEntrenador = value; }
        }

        public string Deportes
        {
            get { return Deporte; }
            set { Deporte = value; }
        }

        public void Listar(DataGridView dgvEntrenadoresConsulta)
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
            dgvEntrenadoresConsulta.DataSource = LectorDataSet.Tables[0];
            conexionBd.Close();
        }

        public void Buscar(string varCodigo)
        {
            try
            {
                try
                {//Recibe la ruta de la BD para conectarse
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
                                varBandera = false;
                                CodigoEntrenador = Lector.GetString(0);
                                NombreEntrenador = Lector.GetString(1);
                                ApellidoEntrenador = Lector.GetString(2);
                                DireccionEntrenador = Lector.GetString(3);
                                ProvinciaEntrenador = (Lector.GetString(4));
                                Deporte = Lector.GetString(5);

                            }
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


        public void Eliminar(string varCodigoEntrenador)
        {
            try
            {
                string Sql = "DELETE FROM ENTRENADORES WHERE ('" + varCodigoEntrenador + "'= [CODIGO ENTRENADOR])";
                //Conecto la base de datos
                conexionBd.ConnectionString = varRutaAccesoBD;
                conexionBd.Open();

                //El comando toma la conexion
                comandoBd.Connection = conexionBd;
                //Este comando me trae la tabla del access
                comandoBd.CommandType = CommandType.Text;
                //Selecciona la tabla
                comandoBd.CommandText = Sql;
                comandoBd.ExecuteNonQuery();


                conexionBd.Close();
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(Convert.ToString(mensaje));
            }
        }

        public void Modificar(string CEntrenador)
        {
            string Sql = "UPDATE ENTRENADORES SET [DIRECCION] = '" + Direccion + "', [PROVINCIA] = '" + Provincia + "', [DEPORTE] = '" + Deporte + "' WHERE [CODIGO ENTRENADOR] = '" + CEntrenador + "'";
            //Conecto la base de datos
            conexionBd.ConnectionString = varRutaAccesoBD;
            conexionBd.Open();

            //El comando toma la conexion
            comandoBd.Connection = conexionBd;
            //Este comando me trae la tabla del access
            comandoBd.CommandType = CommandType.Text;
            //Selecciona la tabla
            comandoBd.CommandText = Sql;
            comandoBd.ExecuteNonQuery();
            conexionBd.Close();
            MessageBox.Show("Cambios Guardados");
        }







    }
}
