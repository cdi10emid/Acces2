
using ClassBusness;
using ClassMetier;
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
        ClassDaoBus ListDept = new ClassDaoBus();
        ClassDaoBus listAllEmp = new ClassDaoBus();
        
        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.DataSource = ListDept.Dept();
            comboBox1.DisplayMember = "Dname";
            comboBox1.ValueMember = "Deptno";
            int Depno = (int)comboBox1.SelectedValue;
            bindingSource1.DataSource = ListDept.Emp(Depno);
            dataGridView2.DataSource = bindingSource1;
            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.Columns.Remove("Empno");
            dataGridView2.Columns.Remove("Deptno");
            if (dataGridView2.SelectedRows.Count != 0)
            {
                int index = dataGridView2.CurrentRow.Index;
                comboBoxName.Text = dataGridView2.Rows[index].Cells[0].Value.ToString();
                comboBoxJob.Text = dataGridView2.Rows[index].Cells[1].Value.ToString();
                comboBoxSal.Text = dataGridView2.Rows[index].Cells[2].Value.ToString();
               
            }
            else
            {
                comboBoxName.Text = "";
                comboBoxJob.Text = "";
                comboBoxSal.Text = "";
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue is int && comboBox1.SelectedValue != null)
            {
                int Depno = (int)comboBox1.SelectedValue;

                bindingSource1.DataSource = ListDept.Emp(Depno);
                dataGridView2.DataSource = bindingSource1;
                dataGridView2.AutoGenerateColumns = true;
                dataGridView2.Columns.Remove("Empno");
                dataGridView2.Columns.Remove("Deptno");
                if (dataGridView2.SelectedRows.Count != 0)
                {
                    int index = dataGridView2.CurrentRow.Index;
                    comboBoxName.Text = dataGridView2.Rows[index].Cells[0].Value.ToString();
                    comboBoxJob.Text = dataGridView2.Rows[index].Cells[1].Value.ToString();
                    comboBoxSal.Text = dataGridView2.Rows[index].Cells[2].Value.ToString();
                }
                else
                {
                    comboBoxName.Text = "";
                    comboBoxJob.Text = "";
                    comboBoxSal.Text = "";
                }



            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxName.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBoxJob.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxSal.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        private Employe EmployeCourant = null;
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            EmployeCourant.Ename = comboBoxName.Text;
            //TODO ajouter autres champs modifiés

            //int resultat = objControleur.Update(EmployeCourant);
            //MessageBox.Show($"{resultat} lignes mises à jour");

            ////Raffraichit la liste des Employés 
            //DGVEmps.Refresh();
        }
    }
}
