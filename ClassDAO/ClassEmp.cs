using System;

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Runtime.Remoting.Messaging;

namespace ClassDAO
{
    public class AccesEmp
    {
        public AccesEmp()
        {

        }
        public int GetNbEmp(int deptNo)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
            try
            {
                cn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "dbo.GetNbEmp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@DEPTNO", SqlDbType.Int).Value = deptNo;
            cmd.Parameters.Add("@NB", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            if (cmd.Parameters["@NB"].Value == null)
            {
                Console.WriteLine("Aucune valeur trouvée");
            }
            return (int)cmd.Parameters["@NB"].Value;
        }
        public DataTable GetEmpByDeptno(int deptNo)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;

            SqlCommand objSelect = new SqlCommand();
            objSelect.Connection = cn;
            objSelect.CommandText = "dbo.GetEmpsByDeptno";
            objSelect.CommandType = CommandType.StoredProcedure;
            objSelect.Parameters.AddWithValue("@DEPTNO", deptNo);


            DataSet objDataset = new DataSet();
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelect);
            objDataAdapter.Fill(objDataset, "EMP");
            return objDataset.Tables["EMP"];
        }
        public DataTable liste_emp(int deptNo)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;

            SqlCommand objSelect = new SqlCommand();
            objSelect.Connection = cn;
            objSelect.CommandText = "dbo.liste_emp";
            objSelect.CommandType = CommandType.StoredProcedure;
            objSelect.Parameters.AddWithValue("@depno", deptNo);


            DataSet objDataset = new DataSet();
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelect);
            objDataAdapter.Fill(objDataset, "EMP");
            return objDataset.Tables["EMP"];
        }

    }
}
