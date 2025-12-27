using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "plotnickov_ExamsDataSet.groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.plotnickov_ExamsDataSet.groups);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

            //SqlConnectionStringBuilder conSB = new SqlConnectionStringBuilder();
            //conSB.DataSource = @"sbd\mssql";
            // conSB.InitialCatalog = "Plotnickov_Exams";
            // conSB.IntegratedSecurity = true;
            // using (SqlConnection con = new SqlConnection(conSB.ConnectionString))
            //{
            //try
            //{
            //con.Open();
            // SqlCommand cmd = new SqlCommand("SELECT * FROM groups", con);
            //SqlDataReader dr = cmd.ExecuteReader();
            //        while (dr.Read())
            //{
            //string a = null;
            //for (int i = 0; i < dr.FieldCount; i++)
            //{
            //a += dr.GetName(i) + ": " + dr[i] + " ";
            //}
            //listBox1.Items.Add(a);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }

    //catch (Exception ex)
    //{
    //MessageBox.Show(ex.Message);
}
//}
//}
//}
