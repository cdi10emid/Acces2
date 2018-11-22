using ClassMetier;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDAO
{
    public class ClassDept
    {
        public ClassDept()
        {

        }
        
        public List<Departement> listeDept()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;

            SqlCommand objSelect = new SqlCommand();
            objSelect.Connection = cn;
            objSelect.CommandText = "dbo.listeDept";
            objSelect.CommandType = CommandType.StoredProcedure;

            
            List<Departement> ListeDept = new List<Departement>();
            
            DataTable objDataset = new DataTable();
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelect);
           
            objDataAdapter.Fill(objDataset);
           
            foreach (DataRow dept in objDataset.Rows)
            {
                Departement Dept = new Departement();

                ListeDept.Add( Dept);
                Dept.Dname = dept["DNAME"].ToString();

            }
            return ListeDept;
        }
    }
}
