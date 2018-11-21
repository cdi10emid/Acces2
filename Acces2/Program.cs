using ClassDAO;
using System.Data;
using System;

namespace AccesSql
{
    public class Program
    {
        static void Main(string[] args)
        {
            AccesEmp DataEmp = new AccesEmp();
            DataTable objDatatable = DataEmp.GetEmpByDeptno(10);

            //Console.WriteLine(objDataset.GetXml());

            foreach (DataRow ligne in objDatatable.Rows)
            {
                Console.WriteLine(ligne[0].ToString());
            }


            Console.ReadKey();
        }
    }
}
