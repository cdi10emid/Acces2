using ClassDAO;
using System.Data;
using System;

namespace AccesSql
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClassDept DataEmp = new ClassDept();
            DataTable objDatatable = DataEmp.listeDept();

            //Console.WriteLine(objDataset.GetXml());

            foreach (DataRow ligne in objDatatable.Rows)
            {
                Console.WriteLine(ligne[0].ToString());
                
            }


            Console.ReadKey();
        }
    }
}
