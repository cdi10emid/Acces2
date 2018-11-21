using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetier
{
    public class Employe
    {
        public int Empno { get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }
        public int Mgr { get; set; }
        public DateTime Hiredate { get; set; }
        public int Sal { get; set; }
        public int Comm { get; set; }
        public int Deptno { get; set; }
        public Employe()
        {

        }
        public Employe(int empno, string ename, string job, int mgr, DateTime hiredate, int sal, int comm, int deptno)
        {
            Empno = empno;
            Ename = ename;
            Job = job;
            Mgr = mgr;
            Hiredate = hiredate;
            Sal = sal;
            Comm = comm;
            Deptno = deptno;
        }

        public Employe(int empno, string ename, string job, int sal)
        {
            Empno = empno;
            Ename = ename;
            Job = job;
            //Mgr = mgr;
            //Hiredate = hiredate;
            Sal = sal;
            //Comm = comm;
            //Deptno = deptno;
        }

        public override string ToString()
        {
            return $" {Empno} {Ename} {Job} {Sal}";
        }


    }
}
