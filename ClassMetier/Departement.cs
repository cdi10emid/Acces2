using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetier
{
   public class Departement
    {
        private int Deptno { get; set; }
        private string Dname { get; set; }
        private string Loc { get; set; }
        public Departement()
        {

        }
        public Departement(int deptno, string dname, string loc)
        {
            Deptno = deptno;
            Dname = dname;
            Loc = loc;
        }
    }
}
