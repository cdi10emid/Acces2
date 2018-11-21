using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetier
{
    class Departement
    {
        public int Deptno { get; set; }
        public string Dname { get; set; }
        public string Loc { get; set; }
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
