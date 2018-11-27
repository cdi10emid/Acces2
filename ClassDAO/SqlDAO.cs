
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class SqlDAO
    {
        //Cette classe est une Singleton
        //Elle est utilisée par toutes les classes DAO 
        //Elle factorise du code d'accès à une base de données SQL Server ACCESS pour créer une connexion, un DataSet
        //Elle obtient la chaine de connection à la base depuis un fichier de configuration App.config

        private static SqlDAO _Instance;

        private SqlConnection cn;

        private SqlDAO()
        {
            cn = new SqlConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
            cn.Open();
        }

        public static SqlDAO GetInstance()
        {
            if (_Instance == null)
                _Instance = new SqlDAO();
            return _Instance;
        }

        private SqlConnection GetConnection()
        {
            //Pour lire la chaine de connexion dans le fichier App.config
            //Le projet a besoin d'une référence sur System.Configuration

            //En mode déconnecté, le système ouvre la connexion, si elle n'est pas ouverte 
            return cn;
        }

        //Crée et peuple un DataSet à partir d'une requête passée en paramètre
        public DataSet ExecuteDataSet(string selectCommand)
        {
            DataSet objDataSet = new DataSet();
            SqlCommand objCommand = new SqlCommand(selectCommand, GetConnection());
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objCommand);
            objDataAdapter.Fill(objDataSet);
            return objDataSet;
        }

        public DataSet ExecuteDataSet(SqlCommand objSelectCommand)
        {
            DataSet objDataSet = new DataSet();
            objSelectCommand.Connection = GetConnection();
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelectCommand);
            objDataAdapter.Fill(objDataSet);
            return objDataSet;
        }

        public int ExecuteNonQuery(SqlCommand objUpdateCommand)
        {
            SqlConnection cn = GetConnection();
            objUpdateCommand.Connection = cn;
            return objUpdateCommand.ExecuteNonQuery();
        }

        public void Close()
        {
            cn.Close();
        }

    }
}
