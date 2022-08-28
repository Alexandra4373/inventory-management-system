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
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace management_system
{
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
            SqlConnection Con = new SqlConnection("@Data Source=(LocalDB)MSSQLLocalDB;AttachDbFilename=C:UsersHER EXCELLENCYOneDriveDocumentsinventory.db.mdf;Integrated Security=True;Connect Timeout=30");
        }


        private void fillcombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("selext catName from categooryTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt= new DataTable();
            dt.Columns.Add("catName", typeof(string));
            dt.Load(rdr);
            prodCat.ValueMember = "catName";
            prodCat.DataSource = dt;
            Con.Close();



        }


        private void ManageProducts_Load(object sender, EventArgs e)
        {
            fillcombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
