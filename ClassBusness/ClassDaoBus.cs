using ClassDAO;
using ClassMetier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBusness
{
    public class ClassDaoBus
    {
        public ClassDaoBus()
        {

        }

        public List<Departement> Dept(){
            return new ClassDept().listeDept();
        }
      

        
    }
}
