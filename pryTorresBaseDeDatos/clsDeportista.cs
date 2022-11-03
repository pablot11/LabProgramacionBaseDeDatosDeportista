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
        //Conexion de la BD
        private OleDbConnection Conexion = new OleDbConnection();
        //Envia un comando/orden a la BD
        private OleDbCommand Comando = new OleDbCommand();
        //Adapta los datos de la base de datos al .net
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        //variable para indicar la ruta de la BD
        private string varCadenaConexion = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";
        //Variable que contiene el nombre de una tabla
        private string varTabla = "DEPORTISTA";



        private string CodigoDeportista;
        private string NombreDeportista;
        private string ApellidoDeportista;
        private string DireccionDeportista;
        private Int32 TelefonoDeportista;
        private Int32 EdadDeportista;
        private string Deporte;

        public string CDeportista
        {
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
            dgvConsultasDeportista.DataSource = DataConsulta.Tables[0];

            Conexion.Close();

        }

        public void Buscar(string varCodigo)
        {
            try
            {
                //Conexion a la BD
                Conexion.ConnectionString = varCadenaConexion;
                Conexion.Open();

                //El comando toma la conexion de la BD
                Comando.Connection = Conexion;
                //trae la tabla del access
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
                Conexion.Close();
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
                string Sql = "DELETE FROM DEPORTISTA WHERE ('" + varCodigoDeportista + "'= [CODIGO DEPORTISTA])";
                //Conexion a la BD
                Conexion.ConnectionString = varCadenaConexion;
                Conexion.Open();

                //El comando toma la conexion de la BD
                Comando.Connection = Conexion;
                //trae la tabla del access
                Comando.CommandType = CommandType.Text;
               
                Comando.CommandText = Sql;
                Comando.ExecuteNonQuery();


                Conexion.Close();
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(Convert.ToString(mensaje));
            }
        }


        public void Modificar(string CDeportista)
        {
            string Sql = "UPDATE DEPORTISTA SET [DIRECCION] = '" + Direccion + "', [TELEFONO] = " + Telefono + ", [EDAD] = " + Edad + ", [DEPORTE] = '" + Deporte + "' WHERE [CODIGO DEPORTISTA] = '" + CDeportista + "'";
            //Conexion a la BD
            Conexion.ConnectionString = varCadenaConexion;
            Conexion.Open();

            //El comando toma la conexion de la BD
            Comando.Connection = Conexion;
            //trae la tabla del access
            Comando.CommandType = CommandType.Text;
         
            Comando.CommandText = Sql;
            Comando.ExecuteNonQuery();


            Conexion.Close();
            MessageBox.Show("Cambios Guardados");
        }

       






    }

}
