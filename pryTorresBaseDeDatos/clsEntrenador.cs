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
        //Establezco la conexion con la base de datos
        private OleDbConnection Conexion = new OleDbConnection();
        //Envia un comando/orden a la  base de datos
        private OleDbCommand Comando = new OleDbCommand();
        //Adapta el dato de la base de datos al .net
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        //variable para indicar la ruta de la base de datos
        private string varCadenaConexion = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";
        //Variable que contiene el nombre de una tabla
        private string varTabla = "ENTRENADORES";


        public bool varBandera = true;
        private string CodigoEntrenador;
        private string NombreEntrenador;
        private string ApellidoEntrenador;
        private string DireccionEntrenador;
        private string ProvinciaEntrenador;
        private string Deporte;

        public string CEntrenador
        {
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
            //Conecto la base de datos
            Conexion.ConnectionString = varCadenaConexion;
            Conexion.Open();
            //El comando toma la conexion
            Comando.Connection = Conexion;
            //Este comando me trae la tabla del access
            Comando.CommandType = CommandType.TableDirect;
            //Selecciona la tabla
            Comando.CommandText = varTabla;
            Adaptador = new OleDbDataAdapter(Comando);
            //Almacena todo en una "tabla"
            DataSet DataConsulta = new DataSet();
            Adaptador.Fill(DataConsulta);
            //Mostraria todo en la grilla
            //La propiedad DataSource toma todo el contenido de un DataSet
            dgvEntrenadoresConsulta.DataSource = DataConsulta.Tables[0];
            Conexion.Close();
        }

        public void Buscar(string varCodigo)
        {
            try
            {
                //Conecto la base de datos
                Conexion.ConnectionString = varCadenaConexion;
                Conexion.Open();

                //El comando toma la conexion
                Comando.Connection = Conexion;
                //Este comando me trae la tabla del access
                Comando.CommandType = CommandType.TableDirect;
                //Selecciona la tabla
                Comando.CommandText = varTabla;
                //Recibo el contenido de la tabla
                OleDbDataReader Lector = Comando.ExecuteReader();
                //Si hay registros ingresa
                
                if (Lector.HasRows)
                {
                 
                    //Mientras tenga datos en la tabla, esto lo va a leer
                    while (Lector.Read())
                    {
                        if (Lector.GetString(0) == varCodigo)
                        {
                            varBandera = false;
                            CodigoEntrenador = Lector.GetString(0);
                            NombreEntrenador = Lector.GetString(1);
                            ApellidoEntrenador= Lector.GetString(2);
                            DireccionEntrenador = Lector.GetString(3);
                            ProvinciaEntrenador = (Lector.GetString(4));
                            Deporte = Lector.GetString(5);
                        }
                       
                    }

                }
                Conexion.Close();
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
                Conexion.ConnectionString = varCadenaConexion;
                Conexion.Open();

                //El comando toma la conexion
                Comando.Connection = Conexion;
                //Este comando me trae la tabla del access
                Comando.CommandType = CommandType.Text;
                //Selecciona la tabla
                Comando.CommandText = Sql;
                Comando.ExecuteNonQuery();


                Conexion.Close();
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
            Conexion.ConnectionString = varCadenaConexion;
            Conexion.Open();

            //El comando toma la conexion
            Comando.Connection = Conexion;
            //Este comando me trae la tabla del access
            Comando.CommandType = CommandType.Text;
            //Selecciona la tabla
            Comando.CommandText = Sql;
            Comando.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("Cambios Guardados");
        }







    }
}
