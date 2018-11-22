
using ClassBusness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClassDaoBus ListDept = new ClassDaoBus();
            this.comboBox1.DataSource = ListDept.Dept();
            comboBox1.DisplayMember =  "Dname";
            comboBox1.ValueMember = "Deptno";

            //ClassDaoBus ListEmp = new ClassDaoBus();
            //this.dataGridView1.DataSource = ListEmp.

        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue is int && comboBox1.SelectedValue != null)
            {
                int Depno = (int)comboBox1.SelectedValue;
                ClassDaoBus ListDept = new ClassDaoBus();
                bindingSource1.DataSource = ListDept.Emp(Depno);
                dataGridView1.DataSource = bindingSource1;

            }


        }

       
    }
}
